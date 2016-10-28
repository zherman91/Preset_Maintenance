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

        private static TreeNode[] AddChildNodes(TreeView MainTreeView, int key)
        {
            
            var presets =
                from presetData in presetDataTable
                where (presetData.KeyCode) == MainTreeView.Nodes[key].Text
                select presetData;

            TreeNode[] keyData = new TreeNode[presets.Count()];

            foreach (DataRow preset in presets)
            {

            }

            return keyData;

            #region
            //for (int i = 0; i < currentNodes; i++)//this was inefficient.. i realize this now
            //{
            //    foreach (DataRow preset in presetDataTable)
            //    {
            //        if (preset.ItemArray[0].ToString() == MainTreeView.Nodes[i].Text)
            //        {
            //            TreeNode child = new TreeNode();
            //            //if (preset.ItemArray[3].ToString().Length != 1)
            //            child.Text = preset.ItemArray[2].ToString();
            //            //else
            //            //  child.Text = preset.ItemArray[2].ToString();
            //            MainTreeView.Nodes[i].Nodes.Add(child);
            //        }
            //    }
            //}
            //Console.WriteLine(testcounter);
            #endregion
        }
        public static void AddParentNodes(TreeView MainTreeView)
        {
            TreeNode[] nodes = new TreeNode[keyMasterDataTable.Rows.Count];
            //TreeNodeCollection nodeCollection = new TreeNodeCollection(MainTreeView);
            TreeNode parent;

            MainTreeView.BeginUpdate();
            MainTreeView.Nodes.Clear();
            for (int i = 0; i < keyMasterDataTable.Rows.Count; i++)
            {
                parent = new TreeNode();
                parent.Text = keyMasterDataTable.Rows[i].ItemArray[0].ToString();
                nodes[i] = parent;
                parent.Nodes.AddRange(AddChildNodes(MainTreeView, i));
                Console.WriteLine(parent.Text);
                MainTreeView.Nodes.AddRange(nodes);
            }
            MainTreeView.EndUpdate();
            //AddChildNodes(MainTreeView);
        }
    }
}
