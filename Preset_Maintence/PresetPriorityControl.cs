using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public partial class PresetPriorityControl : UserControl
    {
        #region Variable Declarations

        PresetForm _parent;
        Preset[] Presets;
        ToolTip toolTip;

        const string originalLegend = "Not Used!";
        const int originalColor = -1;
        const string originalBitMap = "<None>";

        #endregion

        private PresetForm ParentClass { get { return _parent; } set { _parent = value; } }
        public IEnumerable<Button> PriorityButtons
        {
            get
            {
                return _parent.PresetSplitContainer.Panel2.Controls[0].Controls[0].Controls[0].Controls.OfType<Button>();
            }
        }

        public PresetPriorityControl()
        {
            InitializeComponent();
        }

        public PresetPriorityControl(PresetForm parent)
        {
            _parent = parent;
            assignButtonTags();
            composePriority();
        }//TODO: LEFT OFF HERE!

        #region Public Methods

        public void ResetPriority()
        {
            resetPresets();
        }

        public void assignButtonTags()
        {
            Console.WriteLine("Assigning tags...");

            foreach (Button btn in PriorityButtons)
            {
                btn.MouseDown += Btn_MouseDown;
                btn.Click += Btn_Click;
                btn.DoubleClick += Btn_DoubleClick;
                btn.MouseHover += Btn_MouseHover;
                btn.AllowDrop = true;
                var buttonName = int.Parse(btn.Name.Substring(btn.Name.Length - 2, 2));
                btn.Tag = getIndex(buttonName);
            }
        }

        new public void Dispose()
        {
            foreach (Button btn in PriorityButtons)
            {
                btn.Click -= Btn_Click;
                btn.MouseHover -= Btn_MouseHover;
                btn.DoubleClick -= Btn_DoubleClick;
            }
        }

        #endregion

        #region Private Methods

        private void BuildAdvButton(IEnumerable<Button> buttons)
        {
            //foreach (Button btn in buttons)
            //{
            //    btn.Tag = this.parent.NewSearch(buttonName, parent.DataBoundTree.TreeView.SelectedNode.Parent);
            //}
        }

        private void composePriority()
        {
            //need to clear the previous buttons..
            resetPresets();

            var presets = ParentClass.presetMasterTableAdapter.GetPresetPriority((ParentClass.CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode);
            //var buttons = ParentClass.PresetSplitContainer.Panel2.Controls[0].Controls[0].Controls.OfType<Button>().ToDictionary((btn) => int.Parse(btn.Tag.ToString()));
            var buttons = ParentClass.PresetSplitContainer.Panel2.Controls[0].Controls[0].Controls[0].Controls.OfType<Button>().ToDictionary((btn) => int.Parse(btn.Tag.ToString()));


            Presets = new Preset[presets.Count];
            int index = 0;

            foreach (jartrekDataSet.PresetMasterRow row in presets)//create preset objects!!!
            {
                Presets[index] = new Preset(row);//Grabs the entire row and becomes the preset data for this button.

                Button btn = buttons[Presets[index].Data.CurrentPresetData.PresetPriority];

                btn.Tag = Presets[index];
                index++;

                var VirtualPreset = (btn.Tag as Preset).Data.CurrentPresetData;

                if (VirtualPreset.PresetPriority == row.PresetPriority)
                {
                    btn.Text = VirtualPreset.PresetLegend;
                    btn.BackColor = SetColor.GetColor((SetColor.JartrekColors)VirtualPreset.PresetColor);
                    btn.Image = DataAccessor.GetBitMaps(VirtualPreset.PresetCode, VirtualPreset.PresetPicture);
                }
            }
        }

        private void resetPresets()
        {
            Console.WriteLine("Resetting Presets...");

            foreach (Button btn in PriorityButtons)//TODO: Could improve on this
            {
                btn.Text = originalLegend;
                btn.BackColor = default(Color);
                btn.UseVisualStyleBackColor = true;
                btn.Image = DataAccessor.GetBitMaps(originalBitMap);
            }
        }

        private int getIndex(int dbIndex)
        {
            var row = dbIndex % 6;
            var col = Math.Floor((double)dbIndex / 6) + 1;
            int pri = (int)(((col - 1) * 6) + row);

            return pri;
        }

        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            var sndr = sender as Button;
            Console.WriteLine(sndr.Name.ToString());

            try
            {
                Console.WriteLine((sndr.Tag as Preset).Data.CurrentPresetData.PresetCode);
                Console.WriteLine("Printing info for button clicked...");

                foreach (object info in ((sndr.Tag as Preset).Data.CurrentPresetData.ItemArray))
                {
                    Console.WriteLine(info);
                }
            }
            catch (NullReferenceException nr)
            {
                Console.WriteLine("This button is not in use..." + nr.Message);
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var btn = sender as Button;
                var preset = (Preset)btn.Tag;

                ParentClass.DataBoundTree.TreeView.SelectedNode = ParentClass.GetNodeFrom(preset.Data.CurrentPresetData.PresetCode, ParentClass.DataBoundTree.TreeView.Nodes);
            }
            else if (e.Button == MouseButtons.Left)
            {
                (sender as Button).DoDragDrop((sender as Button).Tag, DragDropEffects.All);

            }
        }

        private void Btn_DoubleClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var preset = (Preset)btn.Tag;

            ParentClass.DataBoundTree.TreeView.SelectedNode = ParentClass.GetNodeFrom(preset.Data.CurrentPresetData.PresetCode, ParentClass.DataBoundTree.TreeView.Nodes);

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as Button;
            toolTip = new ToolTip();

            //toolTip.Show((btn.Tag as Preset).Data.CurrentPresetData.PresetCode, Parent);
            try
            {
                toolTip.SetToolTip(btn, ((btn.Tag as Preset).Data.CurrentPresetData.PresetCode));
            }
            catch (NullReferenceException nr)
            {
                toolTip.SetToolTip(btn, "This button is not in use...");
            }
        }

        private class DragBehavior
        {
            private System.Windows.Forms.ListBox ListDragSource;
            private System.Windows.Forms.ListBox ListDragTarget;
            private System.Windows.Forms.CheckBox UseCustomCursorsCheck;
            private System.Windows.Forms.Label DropLocationLabel;

            private int indexOfItemUnderMouseToDrag;
            private int indexOfItemUnderMouseToDrop;

            private Rectangle dragBoxFromMouseDown;
            private Point screenOffset;

            private Cursor MyNoDropCursor;
            private Cursor MyNormalCursor;

            public DragBehavior()
            {

            }
        }
    }
}

