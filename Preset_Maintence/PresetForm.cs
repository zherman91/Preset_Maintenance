using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Preset_Maintenance;
using System.Text.RegularExpressions;
using static Preset_Maintenance.SetColor;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        //TODO: Fix the issue where it populates the priority on each node click! Look for the same key!
        #region Variable Declarations

        List<TreeNode> currentNodeMatches = new List<TreeNode>();
        private TextBox[] prices;
        private static ToolTip error;

        private const string pattern = @"([^A-z0-9\s\$\./\-\*]|[_\[\]\^\`])";
        private string presetCode = null;

        int lastNodeIndex = 0;
        string lastSearchText;
        string currentTax = null;
        string currentPrint = null;
        string currentPresetCode;

        List<Button> removedBtns = new List<Button>();

        private const string BitMapPath = @"C:\Jartrek\BitMaps\";

        #endregion

        bool invalidCharEntered = false;

        //bool sameKey = false;
        TableBinding[] tableBindings;
        public CurrencyManager cm
        {
            get { return (CurrencyManager)BindingContext[jartrekDataSet, "KeyMaster.MyKeyRelate"]; }
        }
        private PresetForm Form => this;
        public DataRowView CurrentRow => presetMasterBindingSource.Current as DataRowView;

        private const string modRow = "Preset_Maintenance.jartrekDataSet+ModifierRow";

        jartrekDataSet.ModifierRow ModifierRow { get; set; }

        jartrekDataSetTableAdapters.ModifierTableAdapter ModTableAdapter;
        jartrekDataSetTableAdapters.ModTemplateTableAdapter ModTemplateAdapter;
        private bool modSelected { get; set; }

        public string Key { get; set; }

        public static string BitPath { get { return BitMapPath; } }

        public PresetPriorityControl PriorityButton { get { return this.MyPriorityControl; } }

        public bool OnChild { get; private set; }
        public bool IsEmptyKey { get; private set; }

        public PresetForm()
        {
            InitializeComponent();
            try
            {
                foreach (string bitmap in Directory.GetFiles(BitPath))
                {
                    bitMap_ComboBox.Items.Add(Path.GetFileName(bitmap));
                }
            }
            catch (DirectoryNotFoundException nf)
            {
                MessageBox.Show(nf.Message);
                return;
            }
        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jartrekDataSet.PresetMaster' table. You can move, or remove it, as needed.
            this.presetMasterTableAdapter.Fill(this.jartrekDataSet.PresetMaster);
            this.keyMasterAdapter.FillXKeys(this.jartrekDataSet.KeyMaster);//fills KeyMaster with only Keys with presets...
                                                                           // this.GoToPriorAdapter.Fill(this.jartrekDataSet.GoToPrior);

            ModTableAdapter = new jartrekDataSetTableAdapters.ModifierTableAdapter();
            int x = ModTableAdapter.Fill(jartrekDataSet.Modifier);
            ModTemplateAdapter = new jartrekDataSetTableAdapters.ModTemplateTableAdapter();
            ModTemplateAdapter.FillModTemp(jartrekDataSet.ModTemplate);

            BindTree(this.DataBoundTree);
            DataBoundTree.TreeView.StateImageList = TreeViewImages;
            EnableEditting(Pricing_GroupBox, false);


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

            this.MyPriorityControl.ParentForm = Form;
            this.ResizeBegin += PresetForm_ResizeBegin;
            this.ResizeEnd += PresetForm_ResizeEnd;

            presetPrintComboBox.Format += PresetPrintComboBox_Format;
            presetTaxComboBox.Format += PresetTaxComboBox_Format;

            keyCodeComboBox.SelectedIndexChanged += KeyCodeComboBox_SelectedIndexChanged;

            presetCodeTextBox.ReadOnly = true;
            keyCodeComboBox.Enabled = false;
            presetMasterBindingNavigator.AddNewItem.Enabled = false;
            DataBoundTree.TreeView.SelectedNode = DataBoundTree.TreeView.Nodes[0].FirstNode;
            DataBoundTree.TreeView.CollapseAll();
            //MyPriorityControl.ComposePriority((CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode);
        }

        private void EnableEditting(CustomGrpBox pricing_GroupBox, bool on)
        {
            foreach (Control ctrl in pricing_GroupBox.Controls)
            {
                ctrl.Enabled = on;
            }
            presetMasterBindingNavigator.Enabled = true;
            Edit_Button.Enabled = true;
        }

        private void KeyCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentRow.IsNew)
            {
                EnableUsed(true);

                Key = (string)((ComboBox)sender).SelectedItem;
                presetMasterBindingSource.RemoveCurrent();
                CurrentRow.CancelEdit();
                presetMasterBindingSource.CancelEdit();
                BoundTreeNode test = GetNodeFrom(Key, DataBoundTree.TreeView.Nodes);
                test.Expand();
                DataBoundTree.TreeView.SelectedNode = test.NextVisibleNode;

                presetMasterBindingNavigator.AddNewItem.PerformClick();

            }
        }

        internal void RefreshNodeImages()
        {
            bool? isPar = DataBoundTree.TreeView.SelectedNode.Parent == null;

            if (isPar.Value)
            {
                foreach (TreeNode node in DataBoundTree.TreeView.SelectedNode.Nodes)
                {
                    if (((BoundTreeNode)node).Preset.Priority > 0)
                        node.StateImageIndex = 1;
                    else
                        node.StateImageIndex = 0;
                }
            }
            else
            {
                foreach (TreeNode node in DataBoundTree.TreeView.SelectedNode.Parent.Nodes)
                {
                    if (((BoundTreeNode)node).Preset.Priority > 0)
                        node.StateImageIndex = 1;
                    else
                        node.StateImageIndex = 0;
                }
            }
        }

        private void PresetTaxComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            switch ((string)e.Value)
            {
                case "Y":
                    e.Value = "Yes";
                    break;
                case "N":
                    e.Value = "No";
                    break;
            }
        }

        private void PresetPrintComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            switch ((string)e.Value)
            {
                case "Y":
                    e.Value = "Yes";
                    break;
                case "N":
                    e.Value = "No";
                    break;
                case "C":
                    e.Value = "Condiment";
                    break;
                case "O":
                    e.Value = "Optional";
                    break;
                case "S":
                    e.Value = "See Server";
                    break;
                case "B":
                    e.Value = "Back Key";
                    break;
            }
        }

        private void PresetForm_ResizeEnd(object sender, EventArgs e)
        {
            DataBoundTree.ResumeLayout();
            Main_SplitCon.ResumeLayout();
        }

        private void PresetForm_ResizeBegin(object sender, EventArgs e)
        {
            DataBoundTree.SuspendLayout();
            Main_SplitCon.SuspendLayout();

        }

        private void BuildColorPicker()
        {
            int i = 1;
            foreach (Button btn in ColorPicker_GroupBox.Controls[0].Controls)
            {
                btn.BackColor = SetColor.GetColor((JartrekColors)i);
                btn.Click += Color_Click;
                btn.Tag = i;
                i++;
            }
        }

        private void Color_Click(object sender, EventArgs e)
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

        private void PresetForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                e.SuppressKeyPress = true;
                Console.WriteLine("Update Shortcut!");
                if (CurrentRow.Row.RowState == DataRowState.Detached || CurrentRow.Row.RowState == DataRowState.Added)
                    ConfirmAdd_Button.PerformClick();
                else
                    Update_Button.PerformClick();
                e.Handled = true;
            }
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                if (!CurrentRow.IsNew)
                {
                    e.SuppressKeyPress = true;
                    Console.WriteLine("Add New Item Shortcut!");
                    presetMasterBindingNavigator.AddNewItem.PerformClick();
                    e.Handled = true;
                }
            }
            else if (e.KeyData == (Keys.Control | Keys.E))
            {
                e.SuppressKeyPress = true;
                Edit_Button.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.Control | Keys.Q))
            {
                e.SuppressKeyPress = true;
                presetMasterBindingSource.CancelEdit();
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.Control | Keys.Shift | Keys.R))
            {
                e.SuppressKeyPress = true;
                MyPriorityControl.RandomizePriority();//Triggering cm_listchanged...
                e.Handled = true;
            }
        }

        private void presetDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            //if (!Regex.IsMatch(e.KeyChar.ToString(), pattern))
            //{
            //    // Stop the character from being entered into the control since it is illegal.
            //    e.Handled = true;
            //}
            //else
            //{
            //    presetCode += e.KeyChar.ToString();

            //    if (presetCode.Length < 10)
            //    {
            //        presetCodeTextBox.Text = presetCode;
            //    }
            //}
        }

        private void EnableUsed(bool on)
        {
            foreach (PresetButton btn in MyPriorityControl.PriorityButtons)
            {
                if (btn.Main_Button.Text != "Not Used!")
                {
                    btn.Enabled = on;
                }
            }
        }

        #region New Row Methods

        private void ConfirmAdd_Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Confirm add button event!");

            int updated = -1;
            if (ValidateInput())
            {
                try
                {
                    this.Validate();
                    this.CurrentRow.EndEdit();
                    presetMasterBindingSource.EndEdit();
                    updated = tableAdapterManager.UpdateAll(jartrekDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Could not add row.. Fix the issue or cancel changes!");
                    return;
                }
                finally
                {
                    if (updated > 0)
                        CompleteAddition();
                }
            }
        }

        private void CompleteAddition()
        {
            Console.WriteLine("Successfully added row!");
            presetCodeTextBox.ReadOnly = true;
            keyCodeComboBox.Enabled = false;
            HideLabels();
            Success_Label.Visible = true;
            ConfirmAdd_Button.Visible = false;
            Update_Button.Visible = true;
            presetMasterBindingNavigator.AddNewItem.Enabled = true;
            MyPriorityControl.ComposePriority(((jartrekDataSet.PresetMasterRow)CurrentRow.Row).KeyCode);
            DataBoundTree.Enabled = true;

            if (IsEmptyKey)
            {
                var currentItem = CurrentRow.Row as jartrekDataSet.PresetMasterRow;
                BoundTreeNode newNode = new BoundTreeNode(currentItem.PresetDesc, currentItem.PresetCode, cm, cm.Position + 1, -1, -1);
                DataBoundTree.TreeView.SelectedNode.Nodes.Add(newNode);
                IsEmptyKey = false;
            }

            FinalizeNode();
            DataBoundTree.SetEvents(jartrekDataSet, true);
            presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
            CancelChanges_Button.Visible = false;
            Update_Button.Visible = true;
            EnableUsed(true);

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
                else
                {
                    Console.WriteLine("Could not add row properly! Please double check your data!");
                    presetMasterBindingSource.ResetCurrentItem();

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
            parent.Tag = (Key.Preset)BuildNewPreset((jartrekDataSet.PresetMasterRow)CurrentRow.Row);
            parent.Name = row.KeyMasterRow.KeyCode;

            child = new TreeNode(newNode.Text);
            child.Tag = (string)newNode.Tag;

            var found = NewItem_TreeView.TreeView.Nodes.Find((string)parent.Name, true);

            if (found.Length == 0)
            {
                parent.Nodes.Add(child);
                NewItem_TreeView.TreeView.Nodes["root"].Nodes.Add(parent);
            }
            else
            {
                found[0].Nodes.Add(child);
            }
        }

        private void presetMasterBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            EnableEditting(Pricing_GroupBox, true);

            currentTax = (CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetTax.ToString();

            currentPrint = (CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetPrint.ToString();
            Console.WriteLine("Adding new event " + Key);
            presetMasterBindingSource.PositionChanged -= presetMasterBindingSource_PositionChanged;
            DataBoundTree.SetEvents(jartrekDataSet, false);
            presetCodeTextBox.ReadOnly = false;
            keyCodeComboBox.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add new item click");

            if (IsEmptyKey)
            {
                Console.WriteLine("Adding new item to empty key...");
                Key = (string)((BoundTreeNode)DataBoundTree.TreeView.SelectedNode).Value;
                keyCodeComboBox.SelectedIndexChanged -= KeyCodeComboBox_SelectedIndexChanged;
                keyCodeComboBox.SelectedItem = Key;
                keyCodeComboBox.SelectedIndexChanged += KeyCodeComboBox_SelectedIndexChanged;

            }
            else
            {
                keyCodeComboBox.Text = Key;
                presetTaxComboBox.SelectedItem = currentTax;
                presetPrintComboBox.SelectedItem = currentPrint;
            }
            DataBoundTree.Enabled = false;
            EnableUsed(false);

            CurrentRow.BeginEdit();

            HideLabels();
            CurrentlyAdding_Label.Visible = true;
            CancelChanges_Button.Visible = true;
            ConfirmAdd_Button.Visible = true;
            Update_Button.Visible = false;
            presetMasterBindingNavigator.AddNewItem.Enabled = false;
            presetDescTextBox.Focus();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    this.Validate();
                    CurrentRow.EndEdit();
                    //presetMasterBindingSource.EndEdit();

                    if ((CurrentRow.Row as jartrekDataSet.PresetMasterRow).RowState == DataRowState.Modified)
                    {
                        if (presetMasterTableAdapter.Update(CurrentRow.Row) > 0)
                        {
                            Console.WriteLine("Successfully Updated Row!");

                            MyPriorityControl.ComposePriority((CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode);
                            HideLabels();
                            UpdateRow_Label.Visible = true;
                            //presetMasterBindingSource.ResetBindings(false);
                            EnableEditting(Pricing_GroupBox, false);
                            CancelChanges_Button.Visible = false;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Input invalid!");
                        return;//input is not valid
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
            }
        }

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

            ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).PresetPrint = (string)presetPrintComboBox.SelectedItem;
            ((jartrekDataSet.PresetMasterRow)CurrentRow.Row).PresetTax = (string)presetTaxComboBox.SelectedItem;

            if (presetCodeTextBox.Text == (string)keyCodeComboBox.SelectedItem)
            {
                MessageBox.Show("Preset Code cannot be the same as the Key Code, please correct this to continue!");
                return false;
            }

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
                if (textBox.Enabled)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        // remove "txt" prefix:
                        var fieldName = textBox.Name.Substring(3);

                        textBox.Focus();

                        MessageBox.Show(string.Format("Field '{0}' cannot be empty.", fieldName));

                        return false;
                    }
                }
            }

            Update_Button.Focus();
            return true;

        }

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
            presetMasterBindingNavigator.AddNewItem.Enabled = true;
            var cmlist = (IBindingList)((BoundTreeNode)e.Node).CurrencyManager.List;
            DataRowView cur = null;
            Key = (string)((BoundTreeNode)e.Node).Value;

            bool? child = e.Node.Parent != null;//Determines whether or not the selected node is a parent or child

            if (((BoundTreeNode)e.Node).TableName == "Modifier")
            {
                Console.WriteLine($"Modifier {((BoundTreeNode)e.Node).Text} Selected...");

                modSelected = true;
            }
            else if (child.Value)//child node selected
            {
                Key = (string)((BoundTreeNode)e.Node.Parent).Value;
                cur = (DataRowView)cm.Current;
                presetMasterBindingSource.Position = cm.Position;

                MyPriorityControl.ComposePriority((((jartrekDataSet.PresetMasterRow)((DataRowView)cm.Current).Row).KeyCode));
                MyPriorityControl.ConfigureCurrents(BuildNewPreset(((DataRowView)cur).Row as jartrekDataSet.PresetMasterRow));
            }
            else
            {
                OnChild = false;
                if (e.Node.Nodes.Count == 0)
                {
                    Console.WriteLine("No presets on this key...");
                    IsEmptyKey = true;
                    Key = (string)((BoundTreeNode)e.Node).Value;
                    MyPriorityControl.ResetPriority();
                }
                else
                {
                    IsEmptyKey = false;
                    Key = (string)((BoundTreeNode)e.Node).Value;
                    //sameKey = true;
                    MyPriorityControl.ComposePriority(Key);
                }
            }
            if (modSelected)
            {
            }
        }

        internal void BindTree(DataBoundTreeView btv)
        {
            tableBindings = new TableBinding[] {
                new TableBinding("PresetMaster", "PresetCode", "PresetDesc"),
                new TableBinding("KeyMaster", "KeyCode", "KeyDesc"),
                new TableBinding("ModTemplate", "TemplatePreset", "TemplateName"),
                new TableBinding("Modifier", "ModifierCode", "ModifierPreset") };

            //setup the initial TreeView defaults.
            btv.TreeView.HideSelection = false;
            btv.Cursor = Cursors.Cross;
            btv.TreeView.HotTracking = Enabled;
            btv.TreeView.Sort();
            btv.TreeView.SelectedImageIndex = -1;

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

        private Key.Preset BuildNewPreset(jartrekDataSet.PresetMasterRow newRow)
        {
            return new Key.Preset(newRow);
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

            CurrentPreset_Button.BackColor = SetColor.GetColor((JartrekColors)(CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetColor);

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

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private void presetMasterBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Binding source data source changed!");
            RefreshNodeImages();
        }

        private void PresetMasterBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine("Binding source list changed " + e.ListChangedType + " " + e.NewIndex + " " + e.OldIndex);

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
            this.jartrekDataSet.PresetMaster.PresetPictureColumn.DefaultValue = "<None>";
            this.jartrekDataSet.PresetMaster.PresetPriorityColumn.DefaultValue = 0;
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
            this.jartrekDataSet.PresetMaster.PresetChipColumn.DefaultValue = "N";
            this.jartrekDataSet.PresetMaster.PresetChippableColumn.DefaultValue = "Y";
            this.jartrekDataSet.PresetMaster.PresetChitScanColumn.DefaultValue = "N";
            this.jartrekDataSet.PresetMaster.PresetChitToggleColumn.DefaultValue = "N";
            this.jartrekDataSet.PresetMaster.PresetPrintChitColumn.DefaultValue = "O";
            this.jartrekDataSet.PresetMaster.PresetPrintColumn.DefaultValue = "N";

        }
        private void presetLegendTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentPreset_Button.Text = (sender as TextBox).Text;
            if (CurrentRow.IsNew)
            {
                presetReceiptTextBox.Text = ((TextBox)sender).Text;
            }
        }
        private void CancelChanges_Button_Click(object sender, EventArgs e)
        {
            presetMasterBindingSource.CancelEdit();
            keyCodeComboBox.Enabled = false;
            presetCodeTextBox.ReadOnly = true;
            bindingNavigatorAddNewItem.Enabled = true;
            ConfirmAdd_Button.Visible = false;
            Update_Button.Visible = true;
            HideLabels();
            CanceledChanges_Label.Visible = false;
            ErrorProvider.Clear();
            EnableUsed(true);
            EnableEditting(Pricing_GroupBox, false);
            DataBoundTree.Enabled = true;

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
        private void presetLegendTextBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
            {
                ((TextBox)sender).Text = " ";
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
        private void bitMap_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected BitMap Changed!");
            // CurrentPreset_Button.Image = GetBitMaps(((jartrekDataSet.PresetMasterRow)CurrentRow.Row).PresetCode, ((ComboBox)sender).SelectedText);
            CurrentPreset_Button.Image = GetBitMap((string)((ComboBox)sender).SelectedItem);


        }
        private Image GetBitMap(string selectedText)
        {
            if (selectedText.Length > 0 && selectedText != "<None>")
                return new Bitmap(BitMapPath + selectedText);
            else
                return null;
        }
        private void ModifierButton_Click(object sender, EventArgs e)
        {
            //this.tm.Enabled = true;
            //ModsGroupBox.Visible = true;

            ModifierForm mods = new ModifierForm(CurrentRow);//pass in the current row?
            var tabs = mods.splitContainer1.Panel2.Controls[0];
            foreach (PresetPriorityControl ctrl in tabs.Controls[0].Controls.OfType<PresetPriorityControl>())
            {
                ctrl.ParentForm = Form;
            }
            mods.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width >= 1435) this.Timer.Enabled = false;
            else this.Width += 12;
        }

        #endregion

        #region Drag & Drop Event

        private void TrashBin_Panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            TrashBin_Panel.BorderStyle = BorderStyle.Fixed3D;

        }
        private void TrashBin_Panel_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Here we go!");
            e.Effect = DragDropEffects.Scroll;
            TrashBin_Panel.BorderStyle = BorderStyle.None;

        }//TODO: INCOMPLETE!
        private void TrashBin_Panel_DragLeave(object sender, EventArgs e)
        {
            TrashBin_Panel.BorderStyle = BorderStyle.None;
        }

        private static void addToTrashPanel(FlowLayoutPanel panel, List<Button> buttons)
        {
            foreach (Button btn in buttons)
                panel.Controls.Add(btn);
            panel.Controls.SetChildIndex(panel.Controls[0], 0);

        }//UNDONE
        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("PresetMaintenance.Key.Preset", false))
            {
                MessageBox.Show("Success!");
            }
        }
        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            Console.WriteLine($"{((BoundTreeNode)e.Item).Value} Dragged");//Value is the KeyCode or PresetCode...

            var effect = DoDragDrop(((BoundTreeNode)e.Item).Preset, DragDropEffects.All);

            if (effect == DragDropEffects.Move)
            {
                RefreshNodeImages();
            }
        }

        #endregion

        #region Current Preset Events

        private void CurrentPreset_Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("Current Preset Button Mouse Down!");
                var preview = ((Button)sender).Tag as Key.Preset;
                Console.WriteLine("Current Preset: " + preview.PresetCode);

            }
        }
        private void CurrentPreset_Button_MouseMove(object sender, MouseEventArgs e)
        {

        }

        #endregion

        private void SortButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("*** Ordering Priority! ***");

            MyPriorityControl.RandomizePriority();
            DataBoundTree.TreeView.SelectedNode = DataBoundTree.TreeView.SelectedNode.NextNode;

            Console.WriteLine("*** Order Complete! ***");

        }

        private void PresetSearch_TextBox_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("Textbox Search Drag Enter!");

            e.Effect = DragDropEffects.All;

        }

        private void PresetSearch_TextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect == DragDropEffects.All)
            {
                Console.WriteLine("Dragged something to search for...");

                if (e.Data.GetDataPresent(typeof(BoundTreeNode)))
                {
                    var data = e.Data.GetData(typeof(BoundTreeNode));
                    ((TextBox)sender).Text = ((BoundTreeNode)data).Text;
                    //can we pass in the row or a preset object? Passing a modifier in could show what is on that template?

                    PresetSearch_Button.PerformClick();

                }
                else if (e.Data.GetDataPresent(typeof(Key.Preset)))
                {
                    var data = e.Data.GetData(typeof(Key.Preset));
                    ((TextBox)sender).Text = ((Key.Preset)data).Description;
                    PresetSearch_Button.PerformClick();
                }
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            EnableEditting(Pricing_GroupBox, true);
            Update_Button.Visible = true;
            CancelChanges_Button.Visible = true;
        }

        private bool ValidInput(string code, out string errorMsg)
        {
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(code))
            {
                errorMsg = "Do not use special characters!";
                return false;
            }
            else
            {
                errorMsg = string.Empty;
                return true;
            }
        }

        private void Input_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            string code = ((TextBox)sender).Text;

            if (!ValidInput(code, out errorMsg))
            {
                e.Cancel = true;
                presetDescTextBox.Select(0, code.Length);
                this.ErrorProvider.SetError(((Control)sender), errorMsg);
            }
        }

        private void Input_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            ErrorProvider.SetError(((TextBox)sender), "");
        }

        private void presetDescTextBox_Leave(object sender, EventArgs e)
        {
            if (CurrentRow.IsNew)
            {
                string potentialCode = ((TextBox)sender).Text.Replace(" ", string.Empty);

                Regex reg = new Regex(@"([^A-z0-9\s\$\./\-\*]|[_\[\]\^\`])");

                if (reg.IsMatch(potentialCode))
                {
                    potentialCode = potentialCode.Replace("-", string.Empty);
                }
                try
                {
                    presetCodeTextBox.Text = (keyCodeComboBox.Text + potentialCode).Remove(10);
                }
                catch (ArgumentOutOfRangeException or)
                {
                    //MessageBox.Show("Out of range!" + or.Message);
                    presetCodeTextBox.Text = (keyCodeComboBox.Text + potentialCode);
                    Console.WriteLine(or.Message);

                }
            }
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

