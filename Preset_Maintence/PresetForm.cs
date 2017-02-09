using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Preset_Maintenance;
using static Preset_Maintenance.SetColor;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        #region Variable Declarations

        List<TreeNode> currentNodeMatches = new List<TreeNode>();
        private TextBox[] prices;

        int lastNodeIndex = 0;
        string lastSearchText;
        string currentKey = null;
        string currentPresetCode;

        List<Button> removedBtns = new List<Button>();

        private const string BitMapPath = @"C:\Jartrek\BitMaps\";

        #endregion

        TableBinding[] tableBindings;
        public CurrencyManager cm
        {
            get { return (CurrencyManager)BindingContext[jartrekDataSet, "KeyMaster.MyKeyRelate"]; }
        }
        private PresetForm Form => this;
        public DataRowView CurrentRow => presetMasterBindingSource.Current as DataRowView;
        public DataRowView Current
        {
            get
            {
                return ((CurrencyManager)BindingContext[jartrekDataSet, "KeyMaster.MyKeyRelate"]).Current as DataRowView;
            }
        }

        public static string BitPath { get { return BitMapPath; } }

        public PresetPriorityControl PriorityButton { get { return this.MyPriorityControl; } }

        public bool onChild { get; private set; }
        public bool isEmptyKey { get; private set; }

        public PresetForm()
        {
            InitializeComponent();

            foreach (string bitmap in Directory.GetFiles(BitPath))
            {
                bitMap_ComboBox.Items.Add(Path.GetFileName(bitmap));
            }
        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jartrekDataSet.PresetMaster' table. You can move, or remove it, as needed.
            this.presetMasterTableAdapter.Fill(this.jartrekDataSet.PresetMaster);
            this.keyMasterTableAdapter1.FillXKeys(this.jartrekDataSet.KeyMaster);//fills KeyMaster with only Keys with presets...
                                                                                 // this.GoToPriorAdapter.Fill(this.jartrekDataSet.GoToPrior);

            //presetMasterBindingSource.Sort = "PresetDesc";

            BindTree(this.DataBoundTree);

            BuildKeyBox();
            BuildColorPicker();

            BindControls();

            DataBoundTree.TreeView.AfterSelect += DataBoundTree_AfterSelect;

            DataBoundTree.TreeView.ItemDrag += TreeView_ItemDrag;
            DataBoundTree.TreeView.DragDrop += TreeView_DragDrop;

            TrashBin_Panel.DragDrop += TrashBin_Panel_DragDrop;
            TrashBin_Panel.DragEnter += TrashBin_Panel_DragEnter;

            presetMasterBindingSource.ListChanged += PresetMasterBindingSource_ListChanged;

            AssignDefaults(jartrekDataSet);

            //priority = new PresetPriorityControl(Form);
            this.MyPriorityControl.ParentForm = Form;
            this.ResizeBegin += PresetForm_ResizeBegin;
            this.ResizeEnd += PresetForm_ResizeEnd;
        }

        private void PresetForm_ResizeEnd(object sender, EventArgs e)
        {
            // Main_SplitCon.Panel2.Show();
            DataBoundTree.ResumeLayout();
            //MyPriorityControl.Visible = true;
            Main_SplitCon.ResumeLayout();


        }

        private void PresetForm_ResizeBegin(object sender, EventArgs e)
        {
            //Main_SplitCon.Panel2.Hide();
            DataBoundTree.SuspendLayout();
            //MyPriorityControl.Visible = false;
            Main_SplitCon.SuspendLayout();
        }

        private void BuildColorPicker()
        {
            int i = 1;
            foreach (Button btn in ColorPicker_GroupBox.Controls[0].Controls)
            {
                btn.BackColor = SetColor.GetColor((JartrekColors)i);
                btn.Click += Btn_Click;
                btn.Tag = i;
                i++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (CurrentRow.IsNew)
            {
                int clr = (int)(((Button)sender).Tag);
                ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).PresetColor = clr;
                CurrentPreset_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)clr);

            }
            else
            {
                int color = (int)(((Button)sender).Tag);
                ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).BeginEdit();
                ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).PresetColor = color;
                // ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).PresetPriority = color;
                ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).EndEdit();
                Update_Button.PerformClick();
            }
        }

        #region New Row Methods

        private void ConfirmAdd_Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Confirm add button event!");

            if (ValidateInput())
            {
                try
                {
                    this.Validate();
                    this.CurrentRow.EndEdit();
                    presetMasterBindingSource.EndEdit();

                    if (tableAdapterManager.PresetMasterTableAdapter.Update(CurrentRow.Row) > 0)
                    {
                        Console.WriteLine("Successfully added row!");
                        HideLabels();
                        Success_Label.Visible = true;
                        ConfirmAdd_Button.Visible = false;
                        Update_Button.Visible = true;
                        presetMasterBindingNavigator.AddNewItem.Enabled = true;
                        MyPriorityControl.ComposePriority();

                        if (isEmptyKey)
                        {
                            var currentItem = CurrentRow.Row as jartrekDataSet.PresetMasterRow;
                            BoundTreeNode newNode = new BoundTreeNode(currentItem.PresetDesc, currentItem.PresetCode, cm, cm.Position + 1, -1, -1);
                            DataBoundTree.TreeView.SelectedNode.Nodes.Add(newNode);
                            isEmptyKey = false;
                        }

                        FinalizeNode();
                        DataBoundTree.SetEvents(jartrekDataSet, true);
                        presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
                        CancelChanges_Button.Visible = false;
                        //need to start a log file as well...
                        if (jartrekDataSet.HasChanges(DataRowState.Modified))
                        {
                            DataSet ds = jartrekDataSet.GetChanges(DataRowState.Modified);

                            foreach (DataRow row in ds.Tables["PresetMaster"].Rows)
                            {
                                row.EndEdit();
                                var test = presetMasterTableAdapter.Update(row);


                            }
                            if (jartrekDataSet.HasChanges())
                            {
                                Console.WriteLine("There are still changes!");

                            }
                        }
                    }
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FinalizeNode()
        {
            TreeNode newNode = new TreeNode();
            TreeNode parent = null;
            TreeNode child = null;
            var row = CurrentRow.Row as jartrekDataSet.PresetMasterRow;

            newNode.Text = row.PresetDesc;
            newNode.Tag = row.PresetCode;
            newNode.Name = row.PresetCode;
            Console.WriteLine($"New nodes value = {newNode.Tag}");

            if (NewItem_TreeView.TreeView.Nodes.Count == 0)
                NewItem_TreeView.TreeView.Nodes.Add("root", "Recently Added Items");

            parent = new TreeNode(row.KeyMasterRow.KeyCode);
            parent.Tag = (Preset)BuildNewPreset((jartrekDataSet.PresetMasterRow)CurrentRow.Row);
            parent.Name = row.KeyMasterRow.KeyCode;

            child = new TreeNode(newNode.Text);
            child.Tag = (string)newNode.Tag;


            var found = NewItem_TreeView.TreeView.Nodes.Find((string)parent.Name, true);

            if (found.Length == 0)
            {
                parent.Nodes.Add(child);
                NewItem_TreeView.TreeView.Nodes["root"].Nodes.Add(parent);
                NewItem_TreeView.TreeView.BringToFront();
                //this.ViewKeys_Button.PerformClick();
            }
            else
            {
                found[0].Nodes.Add(child);
                NewItem_TreeView.TreeView.BringToFront();
            }
        }

        private void presetMasterBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //presetMasterBindingSource.RaiseListChangedEvents = false;
            //jartrekDataSet.EnforceConstraints = false;

            currentKey = (CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode.ToString();
            Console.WriteLine("Adding new event " + currentKey);
            presetMasterBindingSource.PositionChanged -= presetMasterBindingSource_PositionChanged;
            DataBoundTree.SetEvents(jartrekDataSet, false);

            if (DataBoundTree.TreeView.SelectedNode.Nodes.Count == 0)
                Console.WriteLine("Child Node Selected!");
            else
                Console.WriteLine("Key Selected!");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add new item click");

            if (isEmptyKey)
            {
                Console.WriteLine("Adding new item to empty key...");
                currentKey = (string)((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).Value;
            }
            else
            {
                keyCodeComboBox.Text = currentKey;
            }
            CurrentRow.BeginEdit();

            HideLabels();
            CurrentlyAdding_Label.Visible = true;
            CancelChanges_Button.Visible = true;
            ConfirmAdd_Button.Visible = true;
            presetMasterBindingNavigator.AddNewItem.Enabled = false;
            presetDescTextBox.Focus();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CurrentRow.EndEdit();

                if ((CurrentRow.Row as jartrekDataSet.PresetMasterRow).RowState == DataRowState.Modified)
                {
                    //if (jartrekDataSet.HasChanges())
                    //{
                    //    Console.WriteLine("There are changes!");

                    //    DataTable dt = jartrekDataSet.Tables["PresetMaster"];

                    //    if (presetMasterTableAdapter.Update(dt.Select(null, null, DataViewRowState.ModifiedCurrent)) > 0)
                    //    {
                    //        Console.WriteLine("All Changes Updated Successfully!");
                    //        MyPriorityControl.ComposePriority();
                    //    }
                    //}
                    if (tableAdapterManager.UpdateAll(jartrekDataSet) > 0)
                    {
                        Console.WriteLine("Successfully Updated Row!");

                        MyPriorityControl.ComposePriority(KeyPreview_Button.Text);
                        UpdateRow_Label.Visible = true;
                        presetMasterBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    //DataSet ds = jartrekDataSet.GetChanges(DataRowState.Modified);
                    //if (ds != null)
                    //    foreach (DataRow row in ds.Tables["PresetMaster"].Rows)
                    //    {
                    //        row.EndEdit();
                    //        row.AcceptChanges();

                    //    }
                    Console.WriteLine("Input invalid!");
                    return;//input is not valid
                }
            }
        }//TODO: Need to fix this. Can make way more efficient!

        private void BuildKeyBox()
        {
            currentPresetCode = presetCodeTextBox.Text;

            List<string> keys = new List<string>();

            foreach (TreeNode key in DataBoundTree.TreeView.Nodes)
            {
                keys.Add((string)key.Tag);
            }
            keys.Sort();
            keyCodeComboBox.Items.AddRange(keys.ToArray());

        }

        private bool ValidateInput()
        {
            var textBoxes = Pricing_GroupBox.Controls.OfType<Control>()
                            .OfType<TextBox>()
                            .OrderBy(control => control.TabIndex);
            keyCodeComboBox.Focus();//current work around
            presetCodeTextBox.Focus();//current work around

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
                if (textBox.Enabled)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Focus();
                        // remove "txt" prefix:
                        var fieldName = textBox.Name.Substring(3);
                        MessageBox.Show(string.Format("Field '{0}' cannot be empty.", fieldName));

                        return false;
                    }
                }
            }

            Update_Button.Focus();
            return true;

        }//still need to validate and bind comboboxes

        #endregion

        #region TreeView Events

        private void ViewKeys_Click(object sender, EventArgs e)
        {
            if (SearchResults_GroupBox.Visible)
            {
                SearchResults_GroupBox.Visible = false;
                NewItem_TreeView.TreeView.Visible = true;
                NewItem_TreeView.TreeView.Show();
            }
            else
            {
                NewItem_TreeView.TreeView.Visible = false;
                SearchResults_GroupBox.Visible = true;
                SearchResults_GroupBox.Show();
            }
        }

        private void ExpandNodes_Button_Click(object sender, EventArgs e)
        {
            DataBoundTree.TreeView.ExpandAll();
        }

        private void CollapseNodes_Button_Click(object sender, EventArgs e)
        {
            DataBoundTree.TreeView.CollapseAll();
        }

        public void DataBoundTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("My After Select!");
            //if (e.Action == TreeViewAction.ByKeyboard)
            //    return;
            var cmlist = (IBindingList)((BoundTreeNode)e.Node).CurrencyManager.List;
            var currentSourceRow = CurrentRow.Row as jartrekDataSet.PresetMasterRow;
            DataRowView test = null;
            currentKey = (string)((BoundTreeNode)e.Node).Value;

            bool? child = e.Node.Parent != null;//Determines whether or not the selected node is a parent or child

            if (child.Value)//child node selected
            {
                //cmlist.ListChanged -= DataBoundTree.cm_ListChanged;
                test = (DataRowView)cm.Current;
                presetMasterBindingSource.PositionChanged -= presetMasterBindingSource_PositionChanged;
                presetMasterBindingSource.DataSource = cmlist;
                Console.WriteLine("Datasource changed!");
                currentKey = e.Node.Parent.Text;
                presetMasterBindingSource.Position = cm.Position;
                presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
                MyPriorityControl.ComposePriority();
                MyPriorityControl.ConfigureCurrents(BuildNewPreset(((DataRowView)test).Row as jartrekDataSet.PresetMasterRow));

            }
            else
            {
                onChild = false;
                if (e.Node.Nodes.Count == 0)
                {
                    Console.WriteLine("No presets on this key...");
                    isEmptyKey = true;
                    currentKey = (string)((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).Value;
                    presetMasterBindingSource.PositionChanged -= presetMasterBindingSource_PositionChanged;
                    presetMasterBindingSource.DataSource = jartrekDataSet.PresetMaster;
                    presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
                    MyPriorityControl.ResetPriority();
                    KeyPreview_Button.Text = currentKey;

                }
                else
                {
                    isEmptyKey = false;
                    KeyPreview_Button.Text = currentKey;
                    MyPriorityControl.ComposePriority(currentKey);
                    //var cmParent = ((BoundTreeNode)e.Node).CurrencyManager;
                }
            }

        }

        private void PresetMasterBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine("Binding source list changed " + e.ListChangedType);

        }
        #region Should Fix This...
        //TODO: I beleive this is causing the button click events to fire multiple times when clicking a preset...
        //Found out that i wasnt unsubscribing to my events properly...
        //priority.DisposeObj();
        //priority = null;
        //priority = new PresetPriorityControl(Form);

        #endregion

        internal void BindTree(DataBoundTreeView btv)
        {
            tableBindings = new TableBinding[] {
                new TableBinding("PresetMaster", "PresetCode", "PresetDesc"),
                new TableBinding("KeyMaster", "KeyCode", "KeyDesc") };

            //setup the initial TreeView defaults.
            btv.TreeView.HideSelection = false;
            btv.Cursor = Cursors.Cross;
            btv.TreeView.HotTracking = Enabled;
            btv.TreeView.Sort();

            btv.LoadTree(jartrekDataSet, tableBindings);
        }

        #endregion

        #region Binding Source Methods

        private void BindControls()
        {
            var row = presetMasterBindingSource.Current as DataRowView;

            if (row.IsEdit && !row.IsNew)
            {
                var newRow = row.Row as jartrekDataSet.PresetMasterRow;
                Binding bind = new Binding("Checked", presetMasterBindingSource, "PresetChippable", true);
                Binding rem1 = new Binding("Checked", presetMasterBindingSource, "PreRemPrt1", true);
                Binding rem2 = new Binding("Checked", presetMasterBindingSource, "PreRemPrt2", true);

                Binding[] binders = { bind, rem1, rem2 };
                foreach (Binding binder in binders)
                {
                    binder.Format += Binder_Format;
                    binder.Parse += Binder_Parse;
                    binder.NullValue = false;
                }
                PresetChippable_CheckBox.DataBindings.Clear();
                Remote1_CheckBox.DataBindings.Clear();
                Remote2_CheckBox.DataBindings.Clear();
                PresetChippable_CheckBox.DataBindings.Add(bind);
                Remote1_CheckBox.DataBindings.Add(rem1);
                Remote2_CheckBox.DataBindings.Add(rem2);
            }
        }

        private void Binder_Parse(object sender, ConvertEventArgs e)
        {
            if (Convert.IsDBNull(e.Value))
                return;
            if ((bool)e.Value) e.Value = "Y";
            else e.Value = "N";
        }

        private void Binder_Format(object sender, ConvertEventArgs e)
        {
            if (Convert.IsDBNull(e.Value))
            {
                e.Value = bool.Parse(((sender as Binding).Control as CheckBox).Checked.ToString());
                return;
            }
            if ((string)e.Value == "Y") e.Value = true;
            else if ((string)e.Value == "N") e.Value = false;
        }

        private Preset BuildNewPreset(jartrekDataSet.PresetMasterRow newRow)
        {
            return new Preset(newRow);
        }

        public void presetMasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Position changed");
            HideLabels();
            //CurrentPreset_Button.Image = null;
            //((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).CurrencyManager.Position = ((BindingSource)sender).CurrencyManager.Position;

            // This was happening during the insertion of a new row causing the selected node to be null, therefore no filter on the CurrencyManager's List!
            //DataBoundTree.TreeView.SelectedNode = GetNodeFrom(currentCode, DataBoundTree.TreeView.Nodes);
            //((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).CurrencyManager.Position = source.CurrencyManager.Position;
            //cm.Position = ((BindingSource)sender).CurrencyManager.Position;

            CurrentPreset_Button.BackColor = SetColor.GetColor((JartrekColors)int.Parse((CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetColor.ToString()));

        }

        /// <summary>
        /// Gets the node by PresetCode.
        /// </summary>
        /// <param name="presetCode">The preset code.</param>
        /// <param name="root">The root.</param>
        /// <returns>TreeNode.</returns>
        public BoundTreeNode GetNodeFrom(string presetCode, TreeNodeCollection root)
        {
            foreach (BoundTreeNode node in root)
            {
                if (node.Tag.Equals(presetCode)) return node;
                BoundTreeNode next = GetNodeFrom(presetCode, node.Nodes);
                if (next != null) return next;
            }
            return null;
        }

        private BoundTreeNode FindTreeNode(string presetCode, string currentKey, TreeNode startNode)
        {
            BoundTreeNode[] nodesFound = startNode.Nodes.Cast<BoundTreeNode>().Where(r => (string)r.Value == currentKey).ToArray();

            return nodesFound[0];
        }

        private void presetPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPrice = (sender as TextBox).Text;
                prices = new TextBox[] { presetPrice2TextBox, presetPrice3TextBox, presetPrice4TextBox, presetPrice5TextBox, presetPrice6TextBox, presetPrice7TextBox, presetPrice8TextBox };
                try
                {
                    foreach (TextBox price in prices)
                    {
                        price.Focus();//much more logical.
                        price.Text = newPrice;
                    }
                }
                catch (Exception nr)
                {
                    Console.WriteLine(nr.Message);
                }
                presetPrice2TextBox.Focus();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                //MessageBox.Show("What the Ctrl+F?");
                Console.WriteLine("Add New Item Shortcut!");
                presetMasterBindingNavigator.AddNewItem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                Console.WriteLine("Update Shortcut!");
                if (CurrentRow.Row.RowState == DataRowState.Detached || CurrentRow.Row.RowState == DataRowState.Added)
                    ConfirmAdd_Button.PerformClick();
                else
                    Update_Button.PerformClick();
            }
            else if (keyData == (Keys.Control | Keys.Q))
            {
                presetMasterBindingSource.CancelEdit();

            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                DataBoundTree.TreeView.AfterSelect -= DataBoundTree_AfterSelect;
                ((IBindingList)((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).CurrencyManager.List).ListChanged -= DataBoundTree.handlerListChanged;
                presetMasterBindingSource.PositionChanged -= presetMasterBindingSource_PositionChanged;
                presetMasterBindingSource.ListChanged -= PresetMasterBindingSource_ListChanged;

                MyPriorityControl.RandomizePriority();//Triggering cm_listchanged...

                DataBoundTree.TreeView.AfterSelect += DataBoundTree_AfterSelect;
                ((IBindingList)((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).CurrencyManager.List).ListChanged += DataBoundTree.handlerListChanged;
                presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
                presetMasterBindingSource.ListChanged += PresetMasterBindingSource_ListChanged;

                MyPriorityControl.ComposePriority();

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Search Methods

        private void PresetSearch_Button_Click(object sender, EventArgs e)//this needs fixed
        {
            string searchText = PresetSearch_TextBox.Text;
            SearchResults_Label.Text = "Items Found: ";

            if (string.IsNullOrEmpty(searchText))
            {
                Console.WriteLine("You have to enter text to search for ding dong...");
                return;
            }

            if (lastSearchText != searchText)
            {
                //new search
                currentNodeMatches.Clear();
                searchResults_DataGridView.Rows.Clear();
                lastSearchText = searchText;
                lastNodeIndex = 0;
                SearchNodes(searchText, DataBoundTree.TreeView.Nodes[0]);
            }

            if (lastNodeIndex >= 0 && currentNodeMatches.Count > 0 && lastNodeIndex < currentNodeMatches.Count)
            {
                searchResults_DataGridView.Rows.Clear();
                System.Windows.Forms.TreeNode selectedNode = currentNodeMatches[lastNodeIndex];
                lastNodeIndex++;
                DataBoundTree.TreeView.SelectedNode = selectedNode;
                DataBoundTree.TreeView.SelectedNode.Expand();
                // MyPriorityControl.ComposePriority(currentKey);

                for (int i = 0; i < currentNodeMatches.Count; i++)
                {
                    searchResults_DataGridView.Rows.Add(currentNodeMatches[i].Text);
                }
            }
            //PresetSearch_Button.Select();
            SearchResults_Label.Text = SearchResults_Label.Text + " " + currentNodeMatches.Count;
        }
        /// <summary>
        /// Recursivly searches for the specified node and starting node. 
        /// </summary>
        /// <param name="SearchText">The search text.</param>
        /// <param name="StartNode">The start node.</param>
        private void SearchNodes(string SearchText, System.Windows.Forms.TreeNode StartNode)
        {
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    currentNodeMatches.Add(StartNode);
                    //StartNode = currentNodeMatches[0].Parent;
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//recursive search
                };
                StartNode = StartNode.NextNode;
            }
        }
        private void SearchResults_DataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string test = (string)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;
            PresetSearch_TextBox.Text = test;
            PresetSearch_Button.PerformClick();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            PresetSearch_TextBox.Clear();
            searchResults_DataGridView.Rows.Clear();
        }

        #endregion

        #region Private Methods

        private void HideLabels()
        {
            Success_Label.Visible = false;
            CanceledChanges_Label.Visible = false;
            UpdateRow_Label.Visible = false;
            CurrentlyAdding_Label.Visible = false;
        }
        private void AssignDefaults(jartrekDataSet jartrekDataSet)
        {
            this.jartrekDataSet.PresetMaster.KeyCodeColumn.DefaultValue = string.Empty;
            this.jartrekDataSet.PresetMaster.PresetCodeColumn.DefaultValue = string.Empty;
            this.jartrekDataSet.PresetMaster.PresetDescColumn.DefaultValue = "";
            this.jartrekDataSet.PresetMaster.PresetColorColumn.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPriceColumn.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice2Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice3Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice4Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice5Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice6Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice7Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetPrice8Column.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetTaxColumn.DefaultValue = "N";
            this.jartrekDataSet.PresetMaster.PresetMtdAmtColumn.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetMtdQtyColumn.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetYtdAmtColumn.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PresetYtdQtyColumn.DefaultValue = 0;
            this.jartrekDataSet.PresetMaster.PreRemPrt1Column.DefaultValue = "N";
            this.jartrekDataSet.PresetMaster.PreRemPrt2Column.DefaultValue = "N";
            this.jartrekDataSet.PresetMaster.PresetChipColumn.DefaultValue = "Y";
            this.jartrekDataSet.PresetMaster.PresetChippableColumn.DefaultValue = "Y";
            this.jartrekDataSet.PresetMaster.PresetChitScanColumn.DefaultValue = "Y";
            this.jartrekDataSet.PresetMaster.PresetChitToggleColumn.DefaultValue = "Y";
            this.jartrekDataSet.PresetMaster.PresetPrintChitColumn.DefaultValue = "O";

        }
        private void presetDescTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentRow != null)
            {
                if (CurrentRow.IsNew)
                {
                    string presetCode = (keyCodeComboBox.Text + (sender as TextBox).Text).Trim(' ');
                    if (presetCode.Length < 10)
                    {
                        presetCodeTextBox.Text = presetCode;
                    }
                }
            }
        }//need to fix this!
        private void presetLegendTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentPreset_Button.Text = (sender as TextBox).Text;
        }
        private void CancelChanges_Button_Click(object sender, EventArgs e)
        {
            presetMasterBindingSource.CancelEdit();
            bindingNavigatorAddNewItem.Enabled = true;
            ConfirmAdd_Button.Visible = false;
            Update_Button.Visible = true;
            HideLabels();
            CanceledChanges_Label.Visible = true;
            presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
            (sender as Button).Visible = false;
        }
        private void presetPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void PresetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
        }

        #endregion

        #region Drag & Drop Event

        private void TrashBin_Panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }
        private void TrashBin_Panel_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Here we go!");
            e.Effect = DragDropEffects.Link;



            //var dragData = e.Data.GetData(typeof(Preset));
            //var newButton = new MyPresetButton();

            //if (!presetPriorityControl1.IsMouseDown)
            //{
            //    Console.WriteLine($"{((Preset)dragData).PresetCode} Dropped!");

            //    removedBtns.Add(presetPriorityControl1.GetPresetButton(((Preset)dragData), newButton));
            //    addToTrashPanel(TrashBin_Panel, removedBtns);


            //    ((Preset)dragData).Priority = 0;
            //    if (this.presetMasterTableAdapter.Update(((Preset)dragData).Data.CurrentPresetData) > 0)
            //    {
            //        Console.WriteLine($"Successfully removed {((Preset)dragData).PresetCode}");

            //        presetMasterBindingSource.Position = presetMasterBindingSource.Find("PresetCode", ((Preset)dragData).PresetCode);
            //    }
            //}
        }//TODO: INCOMPLETE!
        private static void addToTrashPanel(FlowLayoutPanel panel, List<Button> buttons)
        {
            foreach (Button btn in buttons)
                panel.Controls.Add(btn);
            panel.Controls.SetChildIndex(panel.Controls[0], 0);

        }//UNDONE
        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {

            Console.WriteLine($"{((BoundTreeNode)e.Item).Value} Dragged");//Vale is the KeyCode or PresetCode...

            DoDragDrop(((BoundTreeNode)e.Item), DragDropEffects.Copy);

        }

        #endregion

        #region Current Preset Events

        private void CurrentPreset_Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("Current Preset Button Mouse Down!");
                var preview = ((Button)sender).Tag as Preset;
                Console.WriteLine("Current Preset: " + preview.PresetCode);

            }
        }
        private void CurrentPreset_Button_MouseMove(object sender, MouseEventArgs e)
        {

        }

        #endregion

        public static Bitmap GetBitMaps(string code)
        {
            if (code == "<None>")
                return null;
            else
            {
                Console.WriteLine("Are you using the right bitmap method?");
                return null;
            }

        }
        internal Image GetBitMaps(string presetCode, string bitMap)
        {
            if (bitMap != "<None>" || bitMap == "None")//TODO: FIX THIS
            {
                var presetPic =
                    from presetData in jartrekDataSet.PresetMaster
                    where (presetData.PresetCode) == presetCode
                    select presetData.PresetPicture;

                try
                {
                    return new Bitmap(BitMapPath + bitMap);

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("No picture for this preset..." + e.Message);
                    return null;
                }
            }
            return null;
        }
        internal void ChangeRow(jartrekDataSet.PresetMasterRow rowToEdit, DataRowView editedRow)
        {
            try
            {
                if (rowToEdit != null)
                {
                    if (rowToEdit.RowState == DataRowState.Unchanged)
                    {
                        rowToEdit.ItemArray = editedRow.Row.ItemArray;
                    }
                }
                else
                {
                    Console.WriteLine("Adding a new row..");
                }
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Too many characters!" + e.Message);
            }

            if (presetMasterTableAdapter.Update(CurrentRow.Row) > 0)
            {
                Console.WriteLine("Successfully updated row!");
                MyPriorityControl.ComposePriority(((jartrekDataSet.PresetMasterRow)CurrentRow.Row).KeyCode);
            }
        }
        private void bitMap_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected BitMap Changed!");

        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            ModifierForm mods = new ModifierForm(CurrentRow);//pass in the current row?
            var tabs = mods.splitContainer1.Panel2.Controls[0];
            foreach (PresetPriorityControl ctrl in tabs.Controls[0].Controls.OfType<PresetPriorityControl>())
            {
                ctrl.ParentForm = Form;
            }
            mods.ShowDialog();
        }
    }
    #region - SetColorClass
    public static class SetColor
    {
        [Flags]
        public enum JartrekColors { RegisterDefault = 0, Red = 1, Green = 2, Yellow = 3, Blue = 4, Magenta = 5, Cyan = 6, White = 7, Beige = 8, Goldenrod = 9, Khaki = 10, Plum = 11, Orange = 12, PaleGreen = 13, Pink = 14, Salmon = 15, Sienna = 16, Tan = 17 };
        public static Color GetColor(JartrekColors keyColor)

        {
            Color currentColor = Color.Silver;

            switch (keyColor)
            {
                case JartrekColors.Red:
                    currentColor = Color.Red;
                    break;
                case JartrekColors.Green:
                    currentColor = Color.Lime;
                    break;
                case JartrekColors.Yellow:
                    currentColor = Color.Yellow;
                    break;
                case JartrekColors.Blue:
                    currentColor = Color.Blue;
                    break;
                case JartrekColors.Magenta:
                    currentColor = Color.Fuchsia;
                    break;
                case JartrekColors.Cyan:
                    currentColor = Color.Aqua;
                    break;
                case JartrekColors.White:
                    currentColor = Color.White;
                    break;
                case JartrekColors.Beige:
                    currentColor = Color.Beige;
                    break;
                case JartrekColors.Goldenrod:
                    currentColor = Color.Goldenrod;
                    break;
                case JartrekColors.Khaki:
                    currentColor = Color.Khaki;
                    break;
                case JartrekColors.Plum:
                    currentColor = Color.Plum;
                    break;
                case JartrekColors.Orange:
                    currentColor = Color.Orange;
                    break;
                case JartrekColors.PaleGreen:
                    currentColor = Color.PaleGreen;
                    break;
                case JartrekColors.Pink:
                    currentColor = Color.Pink;
                    break;
                case JartrekColors.Salmon:
                    currentColor = Color.Salmon;
                    break;
                case JartrekColors.Sienna:
                    currentColor = Color.Sienna;
                    break;
                case JartrekColors.Tan:
                    currentColor = Color.Tan;
                    break;
                default: return currentColor;
            }
            return currentColor;
        }
        public static int GetColorInt(JartrekColors keyColor)
        {
            Color currentColor = Color.Silver;
            int colorInt = 1;
            switch (keyColor)
            {
                case JartrekColors.Red:
                    currentColor = Color.Red;
                    colorInt = 1;
                    break;
                case JartrekColors.Green:
                    currentColor = Color.Lime;
                    colorInt = 2;
                    break;
                case JartrekColors.Yellow:
                    currentColor = Color.Yellow;
                    colorInt = 3;
                    break;
                case JartrekColors.Blue:
                    currentColor = Color.Blue;
                    colorInt = 4;
                    break;
                case JartrekColors.Magenta:
                    currentColor = Color.Fuchsia;
                    colorInt = 5;
                    break;
                case JartrekColors.Cyan:
                    currentColor = Color.Aqua;
                    colorInt = 6;
                    break;
                case JartrekColors.White:
                    currentColor = Color.White;
                    colorInt = 7;
                    break;
                case JartrekColors.Beige:
                    currentColor = Color.Beige;
                    colorInt = 8;
                    break;
                case JartrekColors.Goldenrod:
                    currentColor = Color.Goldenrod;
                    colorInt = 9;
                    break;
                case JartrekColors.Khaki:
                    currentColor = Color.Khaki;
                    colorInt = 10;
                    break;
                case JartrekColors.Plum:
                    currentColor = Color.Plum;
                    colorInt = 11;
                    break;
                case JartrekColors.Orange:
                    currentColor = Color.Orange;
                    colorInt = 12;
                    break;
                case JartrekColors.PaleGreen:
                    currentColor = Color.PaleGreen;
                    colorInt = 13;
                    break;
                case JartrekColors.Pink:
                    currentColor = Color.Pink;
                    colorInt = 14;
                    break;
                case JartrekColors.Salmon:
                    currentColor = Color.Salmon;
                    colorInt = 15;
                    break;
                case JartrekColors.Sienna:
                    currentColor = Color.Sienna;
                    colorInt = 16;
                    break;
                case JartrekColors.Tan:
                    currentColor = Color.Tan;
                    colorInt = 17;
                    break;
                default: return colorInt;
            }
            return colorInt;
        }
        public static Color GetNewJarColor()
        {
            int randomColorValue = new Random().Next(1, 17);
            Color currentColor = SetColor.GetColor((SetColor.JartrekColors)randomColorValue);

            return currentColor;
        }
    }
    #endregion
}

