using System;
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
            ShowJarPriorityPanel();
            DataAccessor.AddParentNodes(MainTreeView);
        }
        private void ShowJarPriorityPanel()
        {
            jarPriority.TopLevel = false;
            var left_Split = Main_SplitCon.Panel1.Controls["Nested_SplitCon"] as SplitContainer;
            Nested_SplitCon.Panel2.Controls[0].Controls.Add(jarPriority);
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
            try
            {
                Preview_Button.Text = e.Node.Parent.Text;
                CurrentPreset_Button.Image = DataAccessor.GetBitMaps(e.Node.Text);
                if (CurrentPreset_Button.Image != null)
                    CurrentPreset_Button.Text = "";
                else
                {
                    CurrentPreset_Button.Text = e.Node.Text.ToLower();
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
            if (string.IsNullOrEmpty(searchText))
            {
                return;
            };

            if (lastSearchText != searchText)
            {
                //new search
                currentNodeMatches.Clear();
                lastSearchText = searchText;
                lastNodeIndex = 0;
                SearchNodes(searchText, MainTreeView.Nodes[0]);
            }

            if (lastNodeIndex >= 0 && currentNodeMatches.Count > 0 && lastNodeIndex < currentNodeMatches.Count)
            {
                TreeNode selectedNode = currentNodeMatches[lastNodeIndex];
                lastNodeIndex++;
                this.MainTreeView.SelectedNode = selectedNode;
                MainTreeView.SelectedNode.Expand();
                MainTreeView.Select();
            }
            PresetSearch_Button.Select();

        }
        private void PresetSearch_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
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
    }
}
