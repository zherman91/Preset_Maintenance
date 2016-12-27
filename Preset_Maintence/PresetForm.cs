using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Preset_Maintenance.Key;
using static Preset_Maintenance.SetColor;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        List<TreeNode> currentNodeMatches = new List<TreeNode>();
        jartrekDataSet.PresetMasterRow newRow;

        // object[] pricingControls;
        // object[] checkBoxControls;

        private TextBox[] prices;

        int lastNodeIndex = 0;
        string lastSearchText;
        string currentKey;
        string currentPresetCode;

        public DataRowView CurrentRow { get { return presetMasterBindingSource.Current as DataRowView; } }

        public PresetForm()
        {
            InitializeComponent();

            for (int i = 2; i < searchResults_DataGridView.ColumnCount; i++)
            {
                searchResults_DataGridView.Columns[i].DefaultCellStyle.Format = "c";
            }
            foreach (string bitmap in Directory.GetFiles(DataAccessor.BitPath))
            {
                bitMap_ComboBox.Items.Add(Path.GetFileName(bitmap));
            }
        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jartrekDataSet.PresetMaster' table. You can move, or remove it, as needed.
            this.presetMasterTableAdapter.Fill(this.jartrekDataSet.PresetMaster);

            DataAccessor.AddParentNodes(MainTreeView);

            SearchResults_GroupBox.Show();

            //bindControls();
            //testMethod();
            //testMethod();
        }

        #region New Row Methods

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HideLabels();
            bindingNavigatorAddNewItem.Enabled = false;
            CurrentlyAdding_Label.Visible = true;
            CancelChanges_Button.Visible = true;
            ConfirmAdd_Button.Visible = true;

            keyCodeTextBox.Text = currentKey;
            //keyCodeComboBox.Text = currentKey;

            var newRow = ((presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow);
            if (CurrentRow.IsNew)
            {
                newRow.BeginEdit();
                Preset preset = new Preset(newRow);
                newRow = preset.Data.DefaultPresetData;
                newRow.KeyCode = currentKey;

                presetMasterBindingSource.ResetBindings(false);
            }
        }

        private void presetMasterBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Console.WriteLine("Adding new event..");

            currentKey = keyCodeTextBox.Text;
            currentPresetCode = presetCodeTextBox.Text;

            List<string> keys = new List<string>();

            foreach (TreeNode key in MainTreeView.Nodes)
            {
                keys.Add(key.Text);
            }
            keyCodeComboBox.Items.AddRange(keys.ToArray());
        }

        private void ConfirmAdd_Button_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                if (newRow == null)
                {
                    newRow = ((presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow);

                    presetMasterTableAdapter.Update(newRow);
                    newRow.EndEdit();
                    Update_Button.PerformClick();

                }
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                if (((presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow).RowState != DataRowState.Detached)
                {
                    var presetToEdit = presetMasterTableAdapter.GetData().FindByPresetCode((presetMasterBindingSource.Current as DataRowView).Row.ItemArray[0].ToString());
                    var editedRow = (presetMasterBindingSource.Current as DataRowView);
                    DataAccessor.ChangeRow(presetToEdit, editedRow);
                    HideLabels();
                    UpdateRow_Label.Visible = true;
                }
                else
                {
                    Console.WriteLine("Are you adding a new row?");
                    if ((presetMasterBindingSource.Current as DataRowView).IsNew)
                    {
                        (presetMasterBindingSource.Current as DataRowView).EndEdit();
                        presetMasterTableAdapter.Update((presetMasterBindingSource.Current as DataRowView).Row);
                        bindControls();
                        HideLabels();
                        Success_Label.Visible = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Input invalid!");
                return;//input is not valid
            }
        }

        private bool validateInput()
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

        }

        private void createNewRow(object newRow)
        {
            DataAccessor.AddNewItem(newRow);
        }

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
            MainTreeView.ExpandAll();
        }

        private void CollapseNodes_Button_Click(object sender, EventArgs e)
        {
            MainTreeView.CollapseAll();
        }

        private void MainTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // MessageBox.Show("You just double clicked a node!");
        }

        private void MainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Parent != null)
            {
                var test = presetMasterBindingSource.Position;
                var current = e.Node.Parent.Text;
                var currentRow = presetMasterBindingSource.Current as DataRowView;
                var row = currentRow.Row;
            }
            else//must have been a key clicked.. cool 
            {
                string currentKeyCode = e.Node.Text;
            }
        }

        private void ExpandTree_Button_Click(object sender, EventArgs e)
        {

        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tree = sender as TreeView;
            string currentNodeText;

            if (e.Node.Parent != null)
            {
                currentNodeText = e.Node.Parent.Text;
                presetMasterBindingSource.Position = presetMasterBindingSource.Find("PresetCode", e.Node.Name);
            }
            else
                currentNodeText = e.Node.Text;
            var currentSourceRow = (presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow;
            new PresetPriority(this);

            try
            {
                KeyPreview_Button.Text = currentNodeText;
                CurrentPreset_Button.Image = DataAccessor.GetBitMaps(currentSourceRow.PresetCode, currentSourceRow.PresetPicture);

                if (CurrentPreset_Button.Image != null)
                {
                    CurrentPreset_Button.Text = null;
                    CurrentPreset_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)7);
                }
                else
                {
                    CurrentPreset_Button.Text = e.Node.Text.ToLower();
                    CurrentPreset_Button.BackColor = SetColor.GetNewJarColor();
                }
            }
            catch (NullReferenceException nr)
            {
                Console.WriteLine(nr.Message + "Looks like that node doesnt have a parent...");
            }
        }

        private void MainTreeView_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Binding context changed on tree view");

        }

        #endregion

        #region Pricing Events

        private void bindControls()
        {
            var row = presetMasterBindingSource.Current as DataRowView;
            //var row = ((presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow);
            if (row.IsEdit && !row.IsNew)
            {
                var newRow = row.Row as jartrekDataSet.PresetMasterRow;
                Binding bind = new Binding("Checked", newRow.PresetChippable, string.Empty, true);
                Binding rem1 = new Binding("Checked", newRow.PreRemPrt1, string.Empty, true);
                Binding rem2 = new Binding("Checked", newRow.PreRemPrt2, string.Empty, true);

                Binding[] binders = { bind, rem1, rem2 };
                foreach (Binding binder in binders)
                {
                    binder.Format += (s, v) =>
                    {
                        if ((string)v.Value == "Y")
                            ((s as Binding).Control as CheckBox).Checked = true;
                        else if ((string)v.Value == "N")
                            ((s as Binding).Control as CheckBox).Checked = false;
                    };
                }
                PresetChippable_CheckBox.DataBindings.Clear();
                Remote1_CheckBox.DataBindings.Clear();
                Remote2_CheckBox.DataBindings.Clear();
                PresetChippable_CheckBox.DataBindings.Add(bind);
                Remote1_CheckBox.DataBindings.Add(rem1);
                Remote2_CheckBox.DataBindings.Add(rem2);
            }
            else if (row.IsNew)
            {
                Console.WriteLine("New Row!!");

            }
        }

        private void presetMasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            bindControls();
        }

        private void presetPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPrice = (sender as TextBox).Text;
                prices = new TextBox[] { presetPrice2TextBox, presetPrice3TextBox, presetPrice4TextBox, presetPrice5TextBox, presetPrice6TextBox, presetPrice7TextBox, presetPrice8TextBox };

                foreach (TextBox price in prices)
                {
                    price.Focus();//much more logical.
                    price.Text = newPrice;
                }
                presetPrice2TextBox.Focus();
            }
        }

        private void bitMap_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Console.WriteLine((sender as ComboBox).SelectedItem);
            presetPictureTextBox.Text = (sender as ComboBox).SelectedItem.ToString();
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
                SearchNodes(searchText, MainTreeView.Nodes[0]);
            }

            if (lastNodeIndex >= 0 && currentNodeMatches.Count > 0 && lastNodeIndex < currentNodeMatches.Count)
            {
                searchResults_DataGridView.Rows.Clear();
                TreeNode selectedNode = currentNodeMatches[lastNodeIndex];
                lastNodeIndex++;
                this.MainTreeView.SelectedNode = selectedNode;
                MainTreeView.SelectedNode.Expand();

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
        private void SearchNodes(string SearchText, TreeNode StartNode)
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

        #region CheckBox Events

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox snd = sender as CheckBox;
            var currentRow = ((presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow);
            string result = string.Empty;
            var value = snd.CheckState;

            if (value == CheckState.Checked)
                result = "Y";
            else
                result = "N";

            switch (snd.Name)
            {
                case "PresetChippable_CheckBox":
                    currentRow.PresetChippable = result;
                    break;
                case "Remote1_CheckBox":
                    currentRow.PreRemPrt1 = result;
                    break;
                case "Remote2_CheckBox":
                    currentRow.PreRemPrt2 = result;
                    break;
                default:
                    Console.WriteLine("Invalid name!");
                    break;
            }
        }

        #endregion

        private void keyCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyCodeTextBox.Text = (sender as ComboBox).Text;
        }

        private void presetDescTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentRow.IsNew)
                presetCodeTextBox.Text = (keyCodeTextBox.Text + (sender as TextBox).Text).Trim(' ');
        }

        private void presetMasterBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void HideLabels()
        {
            Success_Label.Visible = false;
            CanceledChanges_Label.Visible = false;
            UpdateRow_Label.Visible = false;
            CurrentlyAdding_Label.Visible = false;
        }

        private void presetMasterBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void presetLegendTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentPreset_Button.Text = (sender as TextBox).Text;
        }

        private void PresetForm_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("keydown");

        }

        private void CancelChanges_Button_Click(object sender, EventArgs e)
        {
            presetMasterBindingSource.CancelEdit();
            bindingNavigatorAddNewItem.Enabled = true;
            ConfirmAdd_Button.Visible = false;
            HideLabels();
            CanceledChanges_Label.Visible = true;
            (sender as Button).Visible = false;
        }
    }

    #region - Preset Priority Class
    public class PresetPriority
    {
        PresetForm parent;

        const string originalLegend = "Not Used!";
        const int originalColor = -1;
        const string originalBitMap = "<None>";

        public PresetPriority(PresetForm pref)
        {
            parent = pref;
            assignButtonTags();
            composePriority();
        }

        private void assignButtonTags()
        {
            var buttons = parent.PresetSplitContainer.Panel2.Controls[0].Controls[0].Controls.OfType<Button>();
            Console.WriteLine("Assigning tags...");

            foreach (Button btn in buttons)
            {
                btn.Click += Btn_Click;
                var buttonName = int.Parse(btn.Name.Substring(btn.Name.Length - 2, 2));
                var row = buttonName % 6;
                var col = Math.Floor((double)buttonName / 6) + 1;
                var pri = (((col - 1) * 6) + row);

                btn.Tag = pri.ToString();
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var sndr = sender as Button;
            Console.WriteLine(sndr.Name.ToString());

            parent.PresetPriority_Label.Text = string.Empty;
            parent.PresetPriority_Label.Text = "Button Position: ";
            parent.PresetPriority_Label.Text = parent.PresetPriority_Label.Text + sndr.Tag.ToString();

            Console.WriteLine(sndr.Text);

        }
        private void composePriority()
        {
            //need to clear the previous buttons..

            resetPresets();

            var presets = DataAccessor.presetMasterAdapter.GetPresetPriority(
                ((parent.presetMasterBindingSource.Current as DataRowView).Row as jartrekDataSet.PresetMasterRow).KeyCode);

            var buttons = parent.PresetSplitContainer.Panel2.Controls[0].Controls[0].Controls.OfType<Button>().ToDictionary((btn) => int.Parse(btn.Tag.ToString()));

            foreach (jartrekDataSet.PresetMasterRow row in presets)
            {
                string legend = row.PresetLegend;
                int color = row.PresetColor;
                string bitMap = row.PresetPicture;
                int priority = row.PresetPriority;

                Button btn = buttons[priority];

                if (int.Parse(btn.Tag.ToString()) == priority)
                {
                    btn.Text = legend;
                    btn.BackColor = SetColor.GetColor((SetColor.JartrekColors)color);
                    btn.Image = DataAccessor.GetBitMaps(row.PresetCode, bitMap);
                }
            }
        }
        private void resetPresets()
        {
            Console.WriteLine("Resetting Presets...");

            foreach (Button btn in parent.PresetSplitContainer.Panel2.Controls[0].Controls[0].Controls.OfType<Button>())
            {
                btn.Text = originalLegend;
                btn.BackColor = default(Color);
                btn.UseVisualStyleBackColor = true;
                btn.Image = DataAccessor.GetBitMaps(originalBitMap);
            }
        }
        private int getIndex(int dbIndex)
        {
            var row = dbIndex % 6;
            var col = Math.Floor((double)dbIndex / 6) + 1;
            int pri = (int)(((col - 1) * 6) + row);

            return pri;
        }
    }

    #endregion

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

