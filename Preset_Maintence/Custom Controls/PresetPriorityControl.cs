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

        PresetForm _parent = null;
        Preset[] Presets;

        const string originalLegend = "Not Used!";
        const int originalColor = -1;
        const string originalBitMap = "<None>";

        #endregion

        static ToolTip toolTip;
        private Button originalButton;
        private Preset newButton;

        Point ptOffset = new Point();

        private PresetForm ParentClass { get { return _parent; } set { _parent = value; } }

        public IEnumerable<MyPresetButton> PriorityButtons
        {
            get
            {
                return _parent.presetPriorityControl1.Controls["Preset_GroupBox"].Controls["PresetPanel"].Controls.OfType<MyPresetButton>();
            }
        }
        public int OriginalPriority { get { return originalPriority; } }
        int originalPriority = -1;
        public int PotentialPriority { get { return potentialPriority; } }
        int potentialPriority = -1;//used only if button below is not in use.
        public int NewPriority { get { return newPriority; } }//could be used for swap?
        int newPriority = -1;

        private int notUsedPri;

        private bool isMouseDown;
        public bool IsMouseDown { get { return isMouseDown; } }

        public PresetPriorityControl()
        {
            InitializeComponent();
            toolTip = new ToolTip();
        }
        public PresetPriorityControl(PresetForm parent)
        {
            _parent = parent;
            AssignButtonTags();
            composePriority();

        }

        #region Public Methods

        public void AssignButtonTags()
        {
            Console.WriteLine("Assigning tags...");

            foreach (MyPresetButton btn in PriorityButtons)
            {
                btn.PresetButton.MouseDown += Btn_MouseDown;
                btn.PresetButton.MouseUp += PresetButton_MouseUp;
                btn.PresetButton.Click += Btn_Click;
                btn.PresetButton.MouseHover += Btn_MouseHover;
                btn.PresetButton.DragEnter += Btn_DragEnter;
                btn.PresetButton.DragOver += PresetButton_DragOver;
                btn.PresetButton.DragDrop += Btn_DragDrop;
                btn.PresetButton.MouseMove += PresetButton_MouseMove;
                btn.PresetButton.AllowDrop = true;
                var buttonName = int.Parse(btn.Name.Substring(btn.Name.Length - 2, 2));
                btn.PresetButton.Tag = getIndex(buttonName);
            }
        }
        public Button GetPresetButton(Preset preset, MyPresetButton btn)
        {
            return ConvertToButton(preset, btn.PresetButton);
        }
        public void ResetPriority()
        {
            resetPresets();
        }
        public void DisposeObj()
        {
            foreach (MyPresetButton btn in PriorityButtons)
            {
                btn.PresetButton.Click -= Btn_Click;
                btn.PresetButton.MouseHover -= Btn_MouseHover;
                btn.PresetButton.MouseDown -= Btn_MouseDown;
                btn.PresetButton.DragDrop -= Btn_DragDrop;
                btn.PresetButton.DragEnter -= Btn_DragEnter;
                btn.PresetButton.DragOver -= PresetButton_DragOver;
                btn.PresetButton.MouseUp -= PresetButton_MouseUp;
                btn.PresetButton.MouseMove -= PresetButton_MouseMove;

            }
            if (toolTip != null)
                toolTip.Dispose();
            base.Dispose();
        }

        #endregion

        #region Private Methods

        private void composePriority()
        {
            //need to clear the previous buttons..
            resetPresets();

            var presets = _parent.presetMasterTableAdapter.GetPresetPriority((_parent.CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode);
            var buttons = PriorityButtons.OfType<MyPresetButton>().ToDictionary((btn) => int.Parse(btn.PresetButton.Tag.ToString()));

            Presets = new Preset[presets.Count];
            int index = 0;

            foreach (jartrekDataSet.PresetMasterRow row in presets)//create preset objects!!!
            {
                Presets[index] = new Preset(row);//Grabs the entire row and becomes the preset data for this button.

                MyPresetButton btn = buttons[Presets[index].Data.CurrentPresetData.PresetPriority];

                btn.PresetButton.Tag = Presets[index];
                index++;

                var VirtualPreset = (btn.PresetButton.Tag as Preset).Data.CurrentPresetData;

                if (VirtualPreset.PresetPriority == row.PresetPriority)
                {
                    btn.PresetButton.Text = VirtualPreset.PresetLegend;
                    btn.PresetButton.BackColor = SetColor.GetColor((SetColor.JartrekColors)VirtualPreset.PresetColor);
                    btn.PresetButton.Image = _parent.GetBitMaps(VirtualPreset.PresetCode, VirtualPreset.PresetPicture);
                }
            }
        }
        private void resetPresets()
        {
            Console.WriteLine("Resetting Presets...");

            foreach (MyPresetButton btn in PriorityButtons)//TODO: Could improve on this
            {
                btn.PresetButton.Text = originalLegend;
                btn.PresetButton.BackColor = default(Color);
                btn.PresetButton.Image = _parent.GetBitMaps(originalBitMap);
                btn.PresetButton.UseVisualStyleBackColor = true;
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

        /// <summary>
        /// Converts a Preset object to an actual button. 
        /// </summary>
        /// <param name="preset">The preset.</param>
        /// <param name="destBtn">My preset button.</param>
        /// <returns>Button.</returns>
        private Button ConvertToButton(Preset preset, Button destBtn)
        {
            Console.WriteLine("Converting To Button...");

            MyPresetButton newBtn = new MyPresetButton();

            destBtn.Tag = (Preset)preset;
            var presetInfo = destBtn.Tag as Preset;
            destBtn.Text = presetInfo.Data.CurrentPresetData.PresetLegend;
            destBtn.BackColor = SetColor.GetColor((SetColor.JartrekColors)presetInfo.Color);

            if (presetInfo.Data.CurrentPresetData.PresetPicture != "<None>")
                destBtn.Image = _parent.GetBitMaps(presetInfo.PresetCode, presetInfo.Data.CurrentPresetData.PresetPicture);
            else
                destBtn.Image = null;

            return destBtn;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var sndr = sender as MyPresetButton;
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
        }//Not working at the moment...
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Down!");

            originalButton = (sender as Button);

            if (e.Button == MouseButtons.Right && ((Button)sender).Tag.GetType() == typeof(Preset))
            {
                var btn = (sender as Button);
                var preset = (Preset)btn.Tag;
                _parent.DataBoundTree.TreeView.SelectedNode = _parent.GetNodeFrom(preset.PresetCode, _parent.DataBoundTree.TreeView.Nodes);
                if (_parent.DataBoundTree.TreeView.SelectedNode == null)
                {

                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                DragDropEffects effect = ((Button)sender).DoDragDrop((sender as Button).Tag, DragDropEffects.Move);

                //handle original button here?
                if (effect == DragDropEffects.Move && originalButton.Tag != newButton)
                {
                    originalButton.Text = originalLegend;
                    originalButton.BackColor = default(Color);
                    originalButton.Image = _parent.GetBitMaps(originalBitMap);
                    originalButton.UseVisualStyleBackColor = true;
                    originalButton.Tag = originalPriority;
                    //UNDONE
                }
            }
            else
            {
                Console.WriteLine("Button was not moved...");
                _parent.presetPriorityTextBox.Text = originalButton.Tag.ToString();
            }
        }
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            toolTip.Dispose();
            toolTip = new ToolTip();

            try
            {
                toolTip.SetToolTip(btn, ((btn.Tag as Preset).Data.CurrentPresetData.PresetCode));
            }
            catch (NullReferenceException)
            {
                toolTip.SetToolTip(btn, "This button is not in use...");
            }
        }//BUG: Tooltip object is not right.. Memory Leak! -- Pretty sure i fixed this
        private void Btn_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Beginning Drag Drop Event");
            isMouseDown = false;

            Preset currentData;

            Button destBtn = sender as Button;
            currentData = (Preset)e.Data.GetData("Preset_Maintenance.Preset");

            //should test for type of element first...

            if (destBtn.Tag.GetType() == typeof(Preset))
            {
                if (e.Data.GetDataPresent("Preset_Maintenance.Preset", false))//data is a preset
                {
                    Point point = ((Button)sender).PointToClient(new Point(e.X, e.Y));
                    Button newPresetBtn = ConvertToButton(currentData, destBtn);

                    //printing out priority read from database...
                    Console.WriteLine("Priority from Preset object: " + ((Preset)newPresetBtn.Tag).Data.CurrentPresetData.PresetPriority);

                    bool newSwap = PositionSwap(((Preset)newPresetBtn.Tag), ((Preset)destBtn.Tag));//we should just swap the entire button...
                }
            }
            else if (int.TryParse(((Button)sender).Tag.ToString(), out notUsedPri))
            {
                Console.WriteLine("Above unused!");
            }
        }
        /// <summary>
        /// Handles the operation of swapping priorties visually and in the database. 
        /// </summary>
        /// <param name="sourcePreset">The source Preset object.</param>
        /// <param name="destPreset">The destination Preset object.</param>
        /// <returns>Button.</returns>
        private bool PositionSwap(Preset sourcePreset, Preset destPreset)
        {
            var sourcePri = ((Preset)sourcePreset).Priority;//need the priority checked here...
            var destPri = ((Preset)destPreset).Priority;

            Console.WriteLine($"Potential swap of Source: {sourcePri} Destination: {destPri}");




            return false;
        }//UNDONE: Left off here!
        private void Btn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            var data = e.Data.GetData(typeof(Preset));
            bool thisIsAdequate = e.Data.GetDataPresent("Preset_Maintenance.Preset", false);

            originalPriority = ((Preset)data).Priority;

            if (int.TryParse(((Button)sender).Tag.ToString(), out potentialPriority))//if button is not in use...
            {
                Console.WriteLine($"Beginning Drag Enter on Position: {potentialPriority}");//parse out the tag if not used.. other than that a preset

            }
            else
            {//UNDONE:need to fix this.. the drag enter event goes off as soon as i click.. need to add a "threshold"
                //must be preset then
                //i now have access to the data row... Can be used to store a potential priority as well as if a swap must be performed...
                Console.WriteLine($"Preset Code: {((Preset)data).PresetCode} Priority: {((Preset)data).Priority}");//could a stack be used here?
                Console.WriteLine($"Currently Above: {((Preset)((Button)sender).Tag).PresetCode} Position: {((Preset)((Button)sender).Tag).Priority} ");
                newButton = ((Preset)(sender as Button).Tag);
                newPriority = ((Preset)((Button)sender).Tag).Priority;//gets the priority of the button below the cursor if it is of type Preset

            }
            Point point = (sender as Button).PointToClient(new Point(e.X, e.Y));//Not sure if i know what to do with this yet...
        }
        private void PresetButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point newPoint = ((Button)sender).PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                ((Button)sender).Location = newPoint;
            }
        }
        private void PresetButton_DragOver(object sender, DragEventArgs e)
        {
            var draggedPreset = e.Data.GetData("Preset_Maintenance.Preset", true);

            var senderTag = ((Button)sender).Tag;

            if (int.TryParse(senderTag.ToString(), out notUsedPri))
            {
                Console.WriteLine($"Currently above position: {senderTag.ToString()}");
            }
            else if (senderTag.GetType() == typeof(Preset))
            {
                if (((Preset)senderTag).PresetCode != ((Preset)originalButton.Tag).PresetCode)
                    Console.WriteLine($"Currently above: {((Preset)senderTag).PresetCode}");

            }
        }
        private void PresetButton_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}