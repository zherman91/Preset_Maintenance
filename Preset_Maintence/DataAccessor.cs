using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTreeView;

namespace Preset_Maintenance
{
    public static class DataAccessor
    {
        #region Variable Declarations

        public static jartrekDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        public static jartrekDataSetTableAdapters.KeyMasterTableAdapter keyMasterAdapter;
        public static jartrekDataSet.KeyMasterDataTable keyMasterDataTable;

        public static jartrekDataSet.PresetMasterDataTable presetMasterDataTable;
        public static jartrekDataSetTableAdapters.PresetMasterTableAdapter presetMasterAdapter;

        private const string BitMapPath = @"C:\Jartrek\BitMaps\";

        public static string BitPath { get { return BitMapPath; } }

        private static TreeNode[] nodes;

        #endregion

        static DataAccessor()
        {
            // presetDataAdapter.FillPresetInfo(presetDataTable);
            //keyMasterAdapter.Fill(keyMasterDataTable);
            presetMasterAdapter = new jartrekDataSetTableAdapters.PresetMasterTableAdapter();
            presetMasterDataTable = new jartrekDataSet.PresetMasterDataTable();
            presetMasterAdapter.Fill(presetMasterDataTable);
        }

        #region TreeView Methods

        private static void AddChildNodes(TreeView MainTreeView)
        {
            for (int i = 0; i < MainTreeView.Nodes.Count; i++)
            {
                var presets =
                    from presetData in presetMasterDataTable
                    where (presetData.KeyCode) == MainTreeView.Nodes[i].Text
                    select presetData;

                foreach (var preset in presets)
                {
                    MainTreeView.Nodes[i].Nodes.Add(preset.PresetCode, preset.PresetDesc);
                }
            }
        }

        public static void AddParentNodes(TreeView MainTreeView)
        {
            MainTreeView.BeginUpdate();
            if (MainTreeView.Nodes == null)
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

        public static void UpdateNodes(TreeView MainTreeView)
        {

        }

        public static void RebuildTree(TreeView MainTreeView, PresetPriorityControl priority)
        {
            if (!presetMasterAdapter.ClearBeforeFill)
                presetMasterDataTable.Clear();
            int rows = presetMasterAdapter.Fill(presetMasterDataTable);

            MainTreeView.Nodes.Clear();
            AddParentNodes(MainTreeView);
            priority.ResetPriority();
        }

        #endregion

        internal static Bitmap GetBitMaps(string code)
        {
            if (code == "<None>")
                return null;
            else
            {
                Console.WriteLine("Are you using the right bitmap method?");
                return null;
            }

        }

        internal static Image GetBitMaps(string presetCode, string bitMap)//can make this wayyyyyy more efficient!
        {
            if (bitMap != "<None>" || bitMap == "None")//TODO: FIX THIS
            {
                var presetPic =
                    from presetData in presetMasterDataTable
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

        internal static void ChangeRow(jartrekDataSet.PresetMasterRow rowToEdit, DataRowView editedRow)
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
                MessageBox.Show("Too many characters!");
            }

            if (presetMasterAdapter.Update(rowToEdit) > 0)
                Console.WriteLine("Successfully updated row!");

        }

        internal static void AddNewItem(object newRow)
        {
            var row = newRow as jartrekDataSet.PresetMasterRow;
        }

    }
}
