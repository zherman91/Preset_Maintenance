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

        public static jartrekDataSetTableAdapters.PresetDataTableAdapter presetDataAdapter = new jartrekDataSetTableAdapters.PresetDataTableAdapter();
        public static jartrekDataSet.PresetDataDataTable presetDataTable = new jartrekDataSet.PresetDataDataTable();

        public static jartrekDataSetTableAdapters.PresetMasterTableAdapter presetMasterAdapter = new jartrekDataSetTableAdapters.PresetMasterTableAdapter();
        public static jartrekDataSet.PresetMasterDataTable presetMasterDataTable = new jartrekDataSet.PresetMasterDataTable();
                
        private const string BitMapPath = @"C:\Jartrek\BitMaps\";

        private static TreeNode[] nodes;

        static DataAccessor()
        {
            presetDataAdapter.FillPresetInfo(presetDataTable);
            keyMasterDataAdapter.FillKeyMasterData(keyMasterDataTable);
        }

        public static void UpdatePreset(DataRowView presetRow)//i have the datarow that has the changes i made here...
        {
            try
            {
                Console.WriteLine($"Updating {presetRow["PresetCode"]}...");
                Console.WriteLine($"Price 1 = {presetRow["PresetPrice"]}");

                var newRow = presetMasterAdapter.GetData().FindByPresetCode(presetRow.Row.ItemArray[1].ToString());

                newRow = (jartrekDataSet.PresetMasterRow)presetRow.Row;

                if (presetMasterAdapter.Update(newRow) > 0)
                    MessageBox.Show("Success!");

            }
            catch (Exception u)
            {

            }

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
                    MainTreeView.Nodes[i].Nodes.Add(preset.PresetCode, preset.PresetDesc);
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
            while (code != "<None>")
            {
                var presetPic =
                         from presetData in presetDataTable
                         where (presetData.PresetCode) == code
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
            return null;
        }

        internal static void ChangeRow(jartrekDataSet.PresetMasterRow rowToEdit, DataRowView editedRow)
        {
            try
            {
                if (rowToEdit.RowState == DataRowState.Unchanged)
                {
                    rowToEdit.ItemArray = editedRow.Row.ItemArray;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Too many characters!");
            }

            if (presetMasterAdapter.Update(rowToEdit) > 0)
                MessageBox.Show("Success!");

        }

        internal static Image GetBitMaps(string presetCode, string bitMap)
        {
            if (bitMap != "<None>")
            {
                var presetPic =
                    from presetData in presetDataTable
                    where (presetData.PresetCode) == presetCode
                    select presetData.PresetPicture;

                try
                {
                    return new Bitmap(BitMapPath + presetPic.First());

                }
                catch (Exception e)
                {
                    Console.WriteLine("New message");
                    return null;
                }
            }
            return null;
        }
    }

    public class RowEvents
    {
        public RowEvents()
        {
            DataAccessor.presetDataTable.RowChanging += PresetDataTable_RowChanging;
        }

        private static void PresetDataTable_RowChanging(object sender, DataRowChangeEventArgs e)
        {
            MessageBox.Show($"The row {e.Row.ItemArray[0]} is changing!");

        }
    }
}
