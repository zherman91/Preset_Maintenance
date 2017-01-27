using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MyTreeView;
using static Preset_Maintenance.SetColor;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        #region Variable Declarations

        List<TreeNode> currentNodeMatches = new List<TreeNode>();
        PresetPriorityControl priority;
        private TextBox[] prices;

        int lastNodeIndex = 0;
        string lastSearchText;
        static string currentKey;
        string currentPresetCode;

        List<Button> removedBtns = new List<Button>();
        private const string BitMapPath = @"C:\Jartrek\BitMaps\";

        #endregion

        public PresetForm Form => this;
        public DataRowView CurrentRow => presetMasterBindingSource.Current as DataRowView;
        public static string BitPath { get { return BitMapPath; } }

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

            presetMasterBindingSource.Sort = "KeyCode";

            BindTree(this.DataBoundTree);

            SearchResults_GroupBox.Show();
            BindControls();
            BuildKeyBox();

            priority = new PresetPriorityControl(Form);//this may cause issues later...

            DataBoundTree.TreeView.AfterSelect += DataBoundTree_AfterSelect;
            DataBoundTree.TreeView.ItemDrag += TreeView_ItemDrag;
            DataBoundTree.TreeView.DragDrop += TreeView_DragDrop;

            TrashBin_Panel.DragDrop += TrashBin_Panel_DragDrop;
            TrashBin_Panel.DragEnter += TrashBin_Panel_DragEnter;

            AssignDefaults(jartrekDataSet);
            presetMasterBindingSource.AddingNew += PresetMasterBindingSource_AddingNew;
            ((IBindingList)presetMasterBindingSource.List).ListChanged += bs_ListChanged;


        }

        private void PresetMasterBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Console.WriteLine("Adding New Event!");
            currentKey = (CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode;
            if (CurrentRow.IsEdit)
                Console.WriteLine("Is edit!");


            // EventWiring(false);
        }

        private void presetMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                this.Validate();
                CurrentRow.EndEdit();
                
                var cm = ((CurrencyManager)BindingContext[jartrekDataSet, "KeyMaster.MyKeyRelate"]);

                var dv = (DataView)cm.List;

                var result = DataBoundTree.TreeView.Nodes.OfType<BoundTreeNode>()
                            .FirstOrDefault(n => n.Tag.Equals((CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyMasterRow.KeyCode));

                var myList = (IBindingList)result.CurrencyManager.List;

                BoundTreeNode newNode = new BoundTreeNode((CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetDesc, CurrentRow, cm, 0, -1, -1);

                //var node = DataBoundTree.TreeView.Nodes.Find((CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyMasterRow.KeyCode, false);

                if (result.Parent == null)
                {
                    result.Nodes.Add(newNode);

                }


                if (this.presetMasterTableAdapter.Update(CurrentRow.Row) > 0)
                    MessageBox.Show("New item added successfully!");

                //EventWiring(true);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            jartrekDataSet.EnforceConstraints = false;
            CurrentRow.BeginEdit();
            keyCodeComboBox.Text = currentKey;

        }

        private void EventWiring(bool on)
        {
            DataBoundTree.SetEvents(jartrekDataSet, on);
            if (on)
            {
                presetMasterBindingSource.PositionChanged += presetMasterBindingSource_PositionChanged;
            }
            else
            {
                presetMasterBindingSource.PositionChanged -= presetMasterBindingSource_PositionChanged;
            }
        }

        private void bs_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemChanged)
                MessageBox.Show("New List Changed Event!" + e.ListChangedType);
            Console.WriteLine(e.ListChangedType);
        }

        #region New Row Methods

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if ((CurrentRow.Row as jartrekDataSet.PresetMasterRow).RowState != DataRowState.Detached)
                {
                    var presetToEdit = presetMasterTableAdapter.GetData().FindByPresetCode((CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetCode);
                    var editedRow = CurrentRow;
                    //add try catch for more solidity...
                    ChangeRow(presetToEdit, editedRow);//BUG: Need to find a better way.. 

                    HideLabels();
                    UpdateRow_Label.Visible = true;
                    //presetMasterBindingSource.Position = presetMasterBindingSource.Position + 1;
                }
                else
                {
                    Console.WriteLine("Input invalid!");
                    return;//input is not valid
                }
            }
        }

        private bool ValidateInput()
        {
            var textBoxes = Pricing_GroupBox.Controls.OfType<Control>()
                            .OfType<TextBox>()
                            .OrderBy(control => control.TabIndex);

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
                SearchResults_GroupBox.Hide();
            else
                SearchResults_GroupBox.Show();
        }

        private void ExpandNodes_Button_Click(object sender, EventArgs e)
        {
            DataBoundTree.TreeView.ExpandAll();
        }

        private void CollapseNodes_Button_Click(object sender, EventArgs e)
        {
            DataBoundTree.TreeView.CollapseAll();
        }

        private void DataBoundTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tree = sender as TreeView;
            string currentNodeText;

            if (e.Node.Parent != null)
            {
                currentNodeText = e.Node.Parent.Text;
                presetMasterBindingSource.Position = presetMasterBindingSource.Find("PresetCode", e.Node.Tag);

                #region Should Fix This...
                //TODO: I beleive this is causing the button click events to fire multiple times when clicking a preset...
                //Found out that i wasnt unsubscribing to my events properly...
                priority.DisposeObj();
                priority = null;
                priority = new PresetPriorityControl(Form);

                #endregion
            }
            else
                currentNodeText = e.Node.Text;

            var currentSourceRow = (presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow;

            try
            {
                KeyPreview_Button.Text = currentNodeText;
                CurrentPreset_Button.Image = GetBitMaps(currentSourceRow.PresetCode, currentSourceRow.PresetPicture);

                if (CurrentPreset_Button.Image != null)
                {
                    CurrentPreset_Button.Text = string.Empty;
                    CurrentPreset_Button.BackColor = GetColor((JartrekColors)currentSourceRow.PresetColor);
                }
                else
                {
                    CurrentPreset_Button.Text = e.Node.Text.ToLower();
                    CurrentPreset_Button.BackColor = GetColor((JartrekColors)currentSourceRow.PresetColor);
                }
                CurrentPreset_Button.Tag = BuildNewPreset(currentSourceRow);
            }
            catch (NullReferenceException nr)
            {
                Console.WriteLine(nr.Message + "Looks like that node doesnt have a parent...");
            }
        }//TODO: This could use some work...

        internal void BindTree(DataBoundTreeView btv)
        {
            TableBinding[] tableBindings = new TableBinding[] {
                new TableBinding("PresetMaster", "PresetCode", "PresetDesc"),
                new TableBinding("KeyMaster", "KeyCode", "KeyCode") };

            //setup the initial TreeView defaults.
            btv.TreeView.HideSelection = false;
            btv.TreeView.SelectedImageIndex = 1;
            btv.TreeView.Sort();

            btv.LoadTree(jartrekDataSet, tableBindings);
            btv.SetEvents(jartrekDataSet, true);

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

        private void presetMasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (!CurrentRow.IsNew)
            {
                Console.WriteLine("Position changed");

                //var source = sender as BindingSource;

                //((CurrencyManager)DataBoundTree.TreeView.BindingContext[jartrekDataSet, "PresetMaster"]).Position = source.CurrencyManager.Position;

                var currentCode = (CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetCode;

                DataBoundTree.TreeView.SelectedNode = GetNodeFrom(currentCode, DataBoundTree.TreeView.Nodes);

                int color;
                if (int.TryParse(presetColorTextBox.Text, out color))
                    CurrentPreset_Button.BackColor = SetColor.GetColor((JartrekColors)int.Parse((CurrentRow.Row as jartrekDataSet.PresetMasterRow).PresetColor.ToString()));
            }
        }

        /// <summary>
        /// Gets the node by PresetCode.
        /// </summary>
        /// <param name="presetCode">The preset code.</param>
        /// <param name="root">The root.</param>
        /// <returns>TreeNode.</returns>
        public MyTreeView.BoundTreeNode GetNodeFrom(string presetCode, TreeNodeCollection root)
        {
            foreach (MyTreeView.BoundTreeNode node in root)
            {
                if (node.Tag.Equals(presetCode)) return node;
                MyTreeView.BoundTreeNode next = GetNodeFrom(presetCode, node.Nodes);
                if (next != null) return next;
            }
            return null;
        }

        private MyTreeView.BoundTreeNode FindTreeNode(string presetCode, string currentKey, System.Windows.Forms.TreeNode startNode)
        {
            MyTreeView.BoundTreeNode[] nodesFound = startNode.Nodes.Cast<MyTreeView.BoundTreeNode>().Where(r => (string)r.Tag == presetCode).ToArray();

            return nodesFound[0] as MyTreeView.BoundTreeNode;
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

        private void bitMap_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Console.WriteLine((sender as ComboBox).SelectedItem);
            presetPictureTextBox.Text = (sender as ComboBox).SelectedItem.ToString();
            CurrentPreset_Button.Image = GetBitMaps(null, (sender as ComboBox).SelectedIndex.ToString());
        }

        private void presetMasterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Current changed!");
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

                for (int i = 0; i < currentNodeMatches.Count; i++)
                {
                    searchResults_DataGridView.Rows.Add(currentNodeMatches[i].Text);
                }
            }
            //PresetSearch_Button.Select();
            SearchResults_Label.Text = SearchResults_Label.Text + " " + currentNodeMatches.Count;
        }
        private MyTreeView.BoundTreeNode NewSearch(string SearchText, System.Windows.Forms.TreeNode StartNode)
        {
            return default(MyTreeView.BoundTreeNode);
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
        private void presetDescTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentRow.IsNew)
            {
                string presetCode = (keyCodeComboBox.Text + (sender as TextBox).Text).Trim(' ');
                if (presetCode.Length < 10)
                {
                    presetCodeTextBox.Text = presetCode;
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
            (sender as System.Windows.Forms.Button).Visible = false;
        }
        private void presetPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // (sender as TextBox).Text = string.Format("{0:#,##0.00}", double.Parse((sender as TextBox).Text));
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
        private void AssignDefaults(jartrekDataSet jartrekDataSet)
        {
            this.jartrekDataSet.PresetMaster.KeyCodeColumn.DefaultValue = string.Empty;
            this.jartrekDataSet.PresetMaster.PresetCodeColumn.DefaultValue = string.Empty;
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
        private void BuildKeyBox()
        {
            currentPresetCode = presetCodeTextBox.Text;

            List<string> keys = new List<string>();

            foreach (System.Windows.Forms.TreeNode key in DataBoundTree.TreeView.Nodes)
            {
                keys.Add((string)key.Tag);
            }
            keyCodeComboBox.Items.AddRange(keys.ToArray());

        }


        #endregion

        #region Drag & Drop Events

        private void TrashBin_Panel_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("Entered Trash!");
            var dragData = e.Data.GetData(typeof(Preset));

            if (e.KeyState == 1 && !presetPriorityControl1.IsMouseDown)
                if (e.Data.GetDataPresent("Preset_Maintenance.Preset"))
                {
                    Console.WriteLine(((Preset)dragData).PresetCode + " Dragged to trash!");
                    e.Effect = DragDropEffects.Move;
                }

        }
        private void TrashBin_Panel_DragDrop(object sender, DragEventArgs e)
        {
            var dragData = e.Data.GetData(typeof(Preset));
            var newButton = new MyPresetButton();

            if (!presetPriorityControl1.IsMouseDown)
            {
                Console.WriteLine($"{((Preset)dragData).PresetCode} Dropped!");

                removedBtns.Add(presetPriorityControl1.GetPresetButton(((Preset)dragData), newButton));
                addToTrashPanel(TrashBin_Panel, removedBtns);


                ((Preset)dragData).Priority = 0;
                if (this.presetMasterTableAdapter.Update(((Preset)dragData).Data.CurrentPresetData) > 0)
                {
                    Console.WriteLine($"Successfully removed {((Preset)dragData).PresetCode}");

                    presetMasterBindingSource.Position = presetMasterBindingSource.Find("PresetCode", ((Preset)dragData).PresetCode);
                }
            }
        }
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
            Console.WriteLine($"{((MyTreeView.BoundTreeNode)e.Item).Value} Dragged");//Vale is the KeyCode or PresetCode...

            DoDragDrop(((MyTreeView.BoundTreeNode)e.Item), DragDropEffects.Copy);

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

        internal Bitmap GetBitMaps(string code)
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

            if (presetMasterTableAdapter.Update(rowToEdit) > 0)
                Console.WriteLine("Successfully updated row!");

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

