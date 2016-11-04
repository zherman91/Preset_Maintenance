using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

        private const string BitMapPath = @"C:\Jartrek\BitMaps\";

        private static TreeNode[] nodes;

        static DataAccessor()
        {
            presetDataAdapter.FillPresetInfo(presetDataTable);
            keyMasterDataAdapter.FillKeyMasterData(keyMasterDataTable);
        }

        private static void AddChildNodes(TreeView MainTreeView)
        {
            for (int i = 0; i < MainTreeView.Nodes.Count; i++)
            {
                var presets =
                    from presetData in presetDataTable
                    where (presetData.KeyCode) == MainTreeView.Nodes[i].Text
                    select presetData;

                foreach (var preset in presets)
                {
                    MainTreeView.Nodes[i].Nodes.Add(preset.PresetDesc);
                }
            }
        }
        public static void AddParentNodes(TreeView MainTreeView)
        {
            MainTreeView.BeginUpdate();
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
                AddChildNodes(MainTreeView);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("It appears there are no presets assigned at this time. " + e.Message);
            }
            MainTreeView.Sort();
            MainTreeView.EndUpdate();
        }
        internal static Bitmap GetBitMaps(string code)
        {
            var presetPic =
                from presetData in presetDataTable
                where (presetData.PresetDesc) == code
                select presetData.PresetPicture;
            try
            {
                return new Bitmap(BitMapPath + presetPic.First());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
