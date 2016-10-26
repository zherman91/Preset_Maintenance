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

        jartrekDataSetTableAdapters.KeyMasterDataTableAdapter keyMasterDataAdapter = new jartrekDataSetTableAdapters.KeyMasterDataTableAdapter();
        jartrekDataSet.KeyMasterDataDataTable keyMasterDataTable = new jartrekDataSet.KeyMasterDataDataTable();

        public PresetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            jarPriority.TopLevel = false;
            SubPanel.Controls[0].Controls.Add(jarPriority);
            jarPriority.FormBorderStyle = FormBorderStyle.None;
            jarPriority.Dock = DockStyle.Fill;
            jarPriority.Show();
            this.GetPresetAmountKeys();
        }

        private void GetPresetAmountKeys()
        {
            int added = keyMasterDataAdapter.FillKeyMasterData(keyMasterDataTable);

            if (added > 0)
            {
                MainTreeView.BeginUpdate();
                MainTreeView.Nodes.Clear();//clears tree view each time method is called.
                // Add a root TreeNode for each Customer object in the ArrayList.
                foreach (DataRow keyCode in keyMasterDataTable.Rows)
                {
                    MainTreeView.Nodes.Add(new TreeNode().Text = keyCode.ItemArray[1].ToString());
                }

                MainTreeView.EndUpdate();
            }
        }

       private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
