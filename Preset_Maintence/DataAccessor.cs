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

        private static TreeNode[] nodes;

        static DataAccessor()
        {
            presetDataAdapter.FillPresetInfo(presetDataTable);
            keyMasterDataAdapter.FillKeyMasterData(keyMasterDataTable);
        }

        private static TreeNode[] AddChildNodes(TreeView MainTreeView, string key)
        {
            int row = 0;
            var presets =
                from presetData in presetDataTable
                where (presetData.KeyCode) == key
                select presetData;

            foreach (var preset in presets)
            {
                MainTreeView.Nodes[row].Nodes.Add(preset.PresetDesc);
            }

            return nodes;

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
            int rows = 0;
            if (MainTreeView.Nodes.Count == 0)
                nodes = new TreeNode[keyMasterDataTable.Rows.Count];
            try
            {
                for (int i = 0; i < keyMasterDataTable.Rows.Count; i++)
                {
                    var parent = new TreeNode();
                    parent.Text = keyMasterDataTable.Rows[i].ItemArray[0].ToString();
                    MainTreeView.Nodes.Add(parent);
                }
                AddChildNodes(MainTreeView, MainTreeView.Nodes[rows].Text);
                rows++;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("It appears there are no presets assigned at this time. " + e.Message);
            }
            MainTreeView.EndUpdate();
            //AddChildNodes(MainTreeView);
        }
    }
}
