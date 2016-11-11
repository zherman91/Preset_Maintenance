﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Preset_Maintenance.KeyData;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        JarPriority jarPriority = new JarPriority();
        List<TreeNode> currentNodeMatches = new List<TreeNode>();
        int lastNodeIndex = 0;
        string lastSearchText;

        public PresetForm()
        {
            InitializeComponent();
        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jartrekDataSet.PresetData' table. You can move, or remove it, as needed.
            this.presetDataTableAdapter.FillPresetInfo(this.jartrekDataSet.PresetData);
            // TODO: This line of code loads data into the 'jartrekDataSet.PresetMaster' table. You can move, or remove it, as needed.
            this.presetMasterTableAdapter.Fill(this.jartrekDataSet.PresetMaster);

            ShowJarPriorityPanel();
            DataAccessor.AddParentNodes(MainTreeView);
        }
        private void ShowJarPriorityPanel()
        {
            jarPriority.TopLevel = false;
            var left_Split = Main_SplitCon.Panel1.Controls["Nested_SplitCon"] as SplitContainer;
            //Nested_SplitCon.Panel2.Controls[0].Controls.Add(jarPriority);
            jarPriority.FormBorderStyle = FormBorderStyle.None;
            jarPriority.Dock = DockStyle.Fill;
            jarPriority.Show();
        }
        private void ViewKeys_Click(object sender, EventArgs e)
        {
            if (Nested_SplitCon.Panel2Collapsed)
                Nested_SplitCon.Panel2Collapsed = false;
            else
                Nested_SplitCon.Panel2Collapsed = true;
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
            MessageBox.Show("You just double clicked a node!");
        }
        private void MainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                Preview_Button.Text = e.Node.Parent.Text;
                CurrentPreset_Button.Image = DataAccessor.GetBitMaps(e.Node.Text);
                if (CurrentPreset_Button.Image != null)
                    CurrentPreset_Button.Text = "";
                else
                    CurrentPreset_Button.Text = e.Node.Text.ToLowerInvariant();
            }
            catch (NullReferenceException nr)
            {
                Console.WriteLine(nr.Message + "Looks like that node doesnt have a parent...");
            }
        }
        private void ExpandTree_Button_Click(object sender, EventArgs e)
        {
            if (Main_SplitCon.Panel2Collapsed)
            {
                Main_SplitCon.Panel2Collapsed = false;
                (sender as Button).Text = ">";
            }
            else
            {
                Main_SplitCon.Panel2Collapsed = true;
                (sender as Button).Text = "<";
            }
        }
        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            presetDataBindingSource.Position = presetDataBindingSource.Find("PresetDesc", (sender as TreeView).SelectedNode.Text);

            // presetDataBindingSource.Position = MainTreeView.SelectedNode.Index;

            try
            {
                Preview_Button.Text = e.Node.Parent.Text;
                CurrentPreset_Button.Image = DataAccessor.GetBitMaps(e.Node.Name);
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
                Preset_Label.Text = e.Node.Text.ToLower();
            }
            catch (NullReferenceException nr)
            {
                Console.WriteLine(nr.Message + "Looks like that node doesnt have a parent...");
            }
        }
        private void PresetSearch_Button_Click(object sender, EventArgs e)
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
                SearchResults_DataGrid.Rows.Clear();
                lastSearchText = searchText;
                lastNodeIndex = 0;
                SearchNodes(searchText, MainTreeView.Nodes[0]);
            }

            if (lastNodeIndex >= 0 && currentNodeMatches.Count > 0 && lastNodeIndex < currentNodeMatches.Count)
            {
                SearchResults_DataGrid.Rows.Clear();
                TreeNode selectedNode = currentNodeMatches[lastNodeIndex];
                lastNodeIndex++;
                this.MainTreeView.SelectedNode = selectedNode;
                MainTreeView.SelectedNode.Expand();
                MainTreeView.Select();
                for (int i = 0; i < currentNodeMatches.Count; i++)
                {
                    SearchResults_DataGrid.Rows.Add(currentNodeMatches[i].Text);
                }
            }
            PresetSearch_Button.Select();
            SearchResults_Label.Text = SearchResults_Label.Text + " " + currentNodeMatches.Count;


        }
        private void PresetSearch_TextBox_TextChanged(object sender, EventArgs e)
        {

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
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//recursive search
                };
                StartNode = StartNode.NextNode;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            PresetSearch_TextBox.Clear();
            SearchResults_DataGrid.Rows.Clear();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            presetDataDataGridView.CurrentCell = presetDataDataGridView.Rows[presetDataDataGridView.NewRowIndex].Cells[1];
        }
        private void SearchResults_DataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string test = (string)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;
            PresetSearch_TextBox.Text = test;
            PresetSearch_Button.PerformClick();
        }

    }
}
