using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public static class DataAccessor
    {
        private static jartrekDataSetTableAdapters.KeyMasterDataAdapter keyMasterDataAdapter = new jartrekDataSetTableAdapters.KeyMasterDataAdapter();
        private static jartrekDataSet.KeyMasterDataDataTable keyMasterDataTable = new jartrekDataSet.KeyMasterDataDataTable();

        private static jartrekDataSetTableAdapters.PresetDataTableAdapter presetDataAdapter = new jartrekDataSetTableAdapters.PresetDataTableAdapter();
        private static jartrekDataSet.PresetDataDataTable presetDataTable = new jartrekDataSet.PresetDataDataTable();

        static DataAccessor()
        {
            presetDataAdapter.FillPresetInfo(presetDataTable);
            keyMasterDataAdapter.FillKeyMasterData(keyMasterDataTable);
        }

        public static void GetPresetAmountKeys(TreeView MainTreeView)
        {
            int added = keyMasterDataAdapter.FillKeyMasterData(keyMasterDataTable);
            int counter = 0;
            if (added > 0)
            {
                MainTreeView.BeginUpdate();
                MainTreeView.Nodes.Clear();//clears tree view each time method is called.
                // Add a root TreeNode for each keycode object in the keymaster table.
                foreach (DataRow keyCode in keyMasterDataTable.Rows)
                {
                    TreeNode parentNode = new TreeNode();
                    TreeNode childNode = new TreeNode();
                    parentNode.Text = keyCode.ItemArray[1].ToString();
                    MainTreeView.Nodes[counter].Nodes.Add(parentNode);
                    counter++;
                }
                MainTreeView.EndUpdate();
            }
            // AddChildNodes(MainTreeView);
        }
        private static void AddChildNodes(TreeView MainTreeView)
        {
            int currentNodes = MainTreeView.Nodes.Count;

            for (int i = 0; i < currentNodes; i++)
            {
                foreach (DataRow preset in presetDataTable)
                {
                    if (preset.ItemArray[0].ToString() == MainTreeView.Nodes[i].Text)
                    {
                        TreeNode child = new TreeNode();
                        //if (preset.ItemArray[3].ToString().Length != 1)
                            child.Text = preset.ItemArray[2].ToString();
                        //else
                          //  child.Text = preset.ItemArray[2].ToString();
                        MainTreeView.Nodes[i].Nodes.Add(child);

                    }
                    else
                    {
                        //MessageBox.Show("Here is the end!");
                    }
                }
            }
        }
        public static void AddParentNodes(TreeView MainTreeView)
        {
            TreeNode[] nodes = new TreeNode[keyMasterDataTable.Rows.Count];
            MainTreeView.BeginUpdate();
            MainTreeView.Nodes.Clear();

            TreeNode parent;
            for (int i = 0; i < keyMasterDataTable.Rows.Count; i++)
            {
                parent = new TreeNode();
                parent.Text = keyMasterDataTable.Rows[i].ItemArray[0].ToString();
                nodes[i] = parent;
            }
            MainTreeView.Nodes.AddRange(nodes);
            MainTreeView.EndUpdate();
            AddChildNodes(MainTreeView);
        }
    }
}
