using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        JarPriority jarPriority = new JarPriority();

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
                //Preview_Button.Image = DataAccessor.GetBitMaps();
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
    }
}
