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
        public static jartrekDataSet.KeyMasterDataDataTable keyMasterDataTable = new jartrekDataSet.KeyMasterDataDataTable();

        public static void GetPresetAmountKeys(TreeView MainTreeView)
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


    }
}
