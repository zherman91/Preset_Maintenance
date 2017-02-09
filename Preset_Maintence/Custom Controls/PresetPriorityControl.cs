using Preset_Maintenance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public partial class PresetPriorityControl : UserControl
    {
        #region Variable Declarations

        Preset[] Presets;

        const string originalLegend = "Not Used!";
        const int originalColor = -1;
        const string originalBitMap = "<None>";

        #endregion

        static ToolTip toolTip;
        private Button originalButton;
        private Preset newButton;

        Point ptOffset = new Point();

        #region Potential Possibility
        public int OriginalPriority { get { return originalPriority; } }
        int originalPriority = -1;
        public int PotentialPriority { get { return potentialPriority; } }
        int potentialPriority = -1;//used only if button below is not in use.
        public int NewPriority { get { return newPriority; } }//could be used for swap?
        int newPriority = -1;

        private int notUsedPri;

        private bool isMouseDown;

        #endregion
        public bool IsMouseDown { get { return isMouseDown; } }

        public new PresetForm ParentForm { get; set; }

        public IEnumerable<PresetButton> PriorityButtons
        {
            get
            {
                return Controls["Preset_GroupBox"].Controls[0].Controls.OfType<PresetButton>();
            }
        }

        public PresetPriorityControl()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            AssignButtonTags();
        }
        public PresetPriorityControl(string args)
        {

        }

        #region Public Methods

        public void AssignButtonTags()
        {
            Console.WriteLine("Assigning Button Tags & Events...");

            foreach (PresetButton btn in PriorityButtons)
            {
                btn.Main_Button.MouseDown += Btn_MouseDown;
                btn.Main_Button.MouseUp += PresetButton_MouseUp;
                btn.Main_Button.Click += Btn_Click;
                btn.Main_Button.MouseHover += Btn_MouseHover;
                btn.Main_Button.DragEnter += Btn_DragEnter;
                btn.Main_Button.DragOver += PresetButton_DragOver;
                btn.Main_Button.DragDrop += Btn_DragDrop;
                btn.Main_Button.MouseMove += PresetButton_MouseMove;
                btn.Main_Button.AllowDrop = true;
                var buttonName = int.Parse(btn.Name.Substring(btn.Name.Length - 2, 2));
                btn.Main_Button.Tag = getIndex(buttonName);
            }
        }
        public Button GetPresetButton(Preset preset, Button btn)//this used to be PresetButton's... experimenting
        {
            return ConvertToButton(preset, btn);
        }
        public void ResetPriority()
        {
            Console.WriteLine("Resetting Presets & Events...");

            foreach (PresetButton btn in PriorityButtons)//TODO: Could improve on this
            {
                btn.Main_Button.Text = originalLegend;
                btn.Main_Button.BackColor = default(Color);
                btn.Main_Button.Image = PresetForm.GetBitMaps(originalBitMap);
                btn.Main_Button.UseVisualStyleBackColor = true;
                btn.Main_Button.Click -= Btn_Click;
                btn.Main_Button.MouseHover -= Btn_MouseHover;
                btn.Main_Button.MouseDown -= Btn_MouseDown;
                btn.Main_Button.DragDrop -= Btn_DragDrop;
                btn.Main_Button.DragEnter -= Btn_DragEnter;
                btn.Main_Button.DragOver -= PresetButton_DragOver;
                btn.Main_Button.MouseUp -= PresetButton_MouseUp;
                btn.Main_Button.MouseMove -= PresetButton_MouseMove;
                //if(btn.Main_Button.Tag.GetType() == typeof(Preset))
                //{
                //    ((Preset)btn.MainPreset_Button.Tag).PropertyChanged -= PresetPriorityControl_PropertyChanged;
                //}
            }
            if (toolTip != null)
                toolTip.Dispose();
        }
        public void DisposeObj()
        {
            //foreach (PresetButton btn in PriorityButtons)
            //{
            //btn.PresetButton.Click -= Btn_Click;
            //btn.PresetButton.MouseHover -= Btn_MouseHover;
            //btn.PresetButton.MouseDown -= Btn_MouseDown;
            //btn.PresetButton.DragDrop -= Btn_DragDrop;
            //btn.PresetButton.DragEnter -= Btn_DragEnter;
            //btn.PresetButton.DragOver -= PresetButton_DragOver;
            //btn.PresetButton.MouseUp -= PresetButton_MouseUp;
            //btn.PresetButton.MouseMove -= PresetButton_MouseMove;

            //}
            //if (toolTip != null)
            //    toolTip.Dispose();
            //base.Dispose();
        }

        #endregion

        #region Private Methods

        public void ComposePriority(object item = null)//pass in the buttons??
        {
            //need to clear the previous buttons..
            ResetPriority();
            AssignButtonTags();
            jartrekDataSet.PresetMasterDataTable presets = null;
            jartrekDataSet.GoToPriorDataTable go = null;

            if (item != null)
            {
                presets = ParentForm.presetMasterTableAdapter.GetPresetPriority((string)item);
                //go = ParentForm.GoToPriorAdapter.GetGoToKeys((string)item);//not yet implemented!

            }
            else
            {
                presets = ParentForm.presetMasterTableAdapter.GetPresetPriority((ParentForm.CurrentRow.Row as jartrekDataSet.PresetMasterRow).KeyCode);
            }
            var buttons = PriorityButtons.ToDictionary((btn) => int.Parse(btn.Main_Button.Tag.ToString()));

            Presets = new Preset[presets.Count];
            int index = 0;

            foreach (jartrekDataSet.PresetMasterRow row in presets)//create preset objects!!!
            {
                Presets[index] = new Preset(row);//Grabs the entire row and becomes the preset data for this button.

                PresetButton btn = buttons[Presets[index].Data.CurrentPresetData.PresetPriority];


                btn.Main_Button.Tag = Presets[index];
                //((Preset)btn.MainPreset_Button.Tag).PropertyChanged += PresetPriorityControl_PropertyChanged;
                index++;

                var VirtualPreset = (btn.Main_Button.Tag as Preset).Data.CurrentPresetData;

                if (VirtualPreset.PresetPriority == row.PresetPriority)
                {
                    btn.Main_Button.Text = VirtualPreset.PresetLegend;
                    btn.Main_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)VirtualPreset.PresetColor);
                    btn.Main_Button.Image = ParentForm.GetBitMaps(VirtualPreset.PresetCode, VirtualPreset.PresetPicture);
                }
            }
        }

        private void PresetPriorityControl_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //private void resetPresets()
        //{
        //    Console.WriteLine("Resetting Presets...");

        //    foreach (PresetButton btn in PriorityButtons)//TODO: Could improve on this
        //    {
        //        btn.PresetButton.Text = originalLegend;
        //        btn.PresetButton.BackColor = default(Color);
        //        btn.PresetButton.Image = PresetForm.GetBitMaps(originalBitMap);
        //        btn.PresetButton.UseVisualStyleBackColor = true;
        //        btn.PresetButton.Click -= Btn_Click;
        //        btn.PresetButton.MouseHover -= Btn_MouseHover;
        //        btn.PresetButton.MouseDown -= Btn_MouseDown;
        //        btn.PresetButton.DragDrop -= Btn_DragDrop;
        //        btn.PresetButton.DragEnter -= Btn_DragEnter;
        //        btn.PresetButton.DragOver -= PresetButton_DragOver;
        //        btn.PresetButton.MouseUp -= PresetButton_MouseUp;
        //        btn.PresetButton.MouseMove -= PresetButton_MouseMove;
        //    }
        //}
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

            destBtn.Tag = (Preset)preset;
            var presetInfo = (Preset)destBtn.Tag;
            destBtn.Text = presetInfo.Data.CurrentPresetData.PresetLegend;
            destBtn.BackColor = SetColor.GetColor((SetColor.JartrekColors)presetInfo.Color);

            if (presetInfo.Data.CurrentPresetData.PresetPicture != "<None>")
                destBtn.Image = ParentForm.GetBitMaps(presetInfo.PresetCode, presetInfo.Data.CurrentPresetData.PresetPicture);
            else
                destBtn.Image = null;

            return destBtn;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var sndr = sender as PresetButton;
            Console.WriteLine(sndr.Name.ToString() + " Clicked!");

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
            originalButton = sender as Button;

            if (e.Button == MouseButtons.Right && originalButton.Tag.GetType() == typeof(Preset))
            {
                var btn = (sender as Button);
                var preset = (Preset)btn.Tag;
                //ParentForm.DataBoundTree.TreeView.AfterSelect -= ParentForm.DataBoundTree_AfterSelect;
                ParentForm.DataBoundTree.TreeView.SelectedNode = ParentForm.DataBoundTree.SelectNode(preset.PresetCode, ParentForm.DataBoundTree.TreeView.Nodes);
                //ParentForm.DataBoundTree.TreeView.AfterSelect += ParentForm.DataBoundTree_AfterSelect;

                ConfigureCurrents(preset);
            }
            else if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                DragDropEffects effect = originalButton.DoDragDrop(originalButton.Tag, DragDropEffects.All);
                isMouseDown = false;
                //handle original button here?
                if (effect == DragDropEffects.Move && originalButton.Tag != newButton)
                {
                    originalButton.Text = originalLegend;
                    originalButton.BackColor = default(Color);
                    originalButton.Image = PresetForm.GetBitMaps(originalBitMap);
                    originalButton.UseVisualStyleBackColor = true;
                    originalButton.Tag = originalPriority;

                    //UNDONE
                }
                else if (effect == DragDropEffects.Link)
                {
                    originalButton.Text = originalLegend;
                    originalButton.BackColor = default(Color);
                    originalButton.Image = PresetForm.GetBitMaps(originalBitMap);
                    originalButton.UseVisualStyleBackColor = true;
                    originalButton.Tag = originalPriority;
                    ParentForm.CurrentRow.BeginEdit();
                    ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).PresetPriority = 0;
                    ParentForm.CurrentRow.EndEdit();
                    if (ParentForm.tableAdapterManager.UpdateAll(ParentForm.jartrekDataSet) > 0)
                        Console.WriteLine("Removed!");
                }
            }
            else
            {
                Console.WriteLine("Button was not moved...");
                if (ParentForm.CurrentRow.IsNew)
                {
                    int pri = (int)originalButton.Tag;
                    ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).PresetPriority = pri;
                    //((DataRowView)ParentForm.CurrentRow).EndEdit();
                    //ParentForm.presetMasterBindingSource.EndEdit();
                }
                else
                {
                    int pri = (int)originalButton.Tag;
                    ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).PresetPriority = pri;
                    ((DataRowView)ParentForm.CurrentRow).EndEdit();
                }
            }
        }

        public void ConfigureCurrents(Preset preset)
        {
            if (preset.BitMap != "<None>")
            {
                ParentForm.CurrentPreset_Button.Image = ParentForm.GetBitMaps(preset.PresetCode, preset.BitMap);
                ParentForm.CurrentPreset_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)preset.Color);
                ParentForm.CurrentPreset_Button.Text = preset.Data.CurrentPresetData.PresetLegend;
            }
            else
            {
                ParentForm.CurrentPreset_Button.Image = null;
                ParentForm.CurrentPreset_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)preset.Color);
                ParentForm.CurrentPreset_Button.Text = preset.Data.CurrentPresetData.PresetLegend;
            }
            ParentForm.KeyPreview_Button.Text = preset.KeyCode;
            //ParentForm.KeyPreview_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)preset.Data.CurrentPresetData.KeyMasterRow.KeyColor);
            ParentForm.CurrentPreset_Button.Tag = preset;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            toolTip.Dispose();
            toolTip = new ToolTip();

            try
            {
                var preset = (btn.Tag as Preset).Data.CurrentPresetData;
                toolTip.SetToolTip(btn, (preset.PresetCode + "\n" + preset.PresetPriority));

            }
            catch (NullReferenceException nr)
            {
                toolTip.SetToolTip(btn, "This button is not in use...");
                Console.WriteLine("Unused..." + nr.Message);

            }
        }

        private void Btn_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Beginning Drag Drop Event");
            isMouseDown = false;

            Preset currentData;

            var destBtn = ((Button)sender);
            currentData = (Preset)e.Data.GetData("Preset_Maintenance.Preset");

            //should test for type of element first...

            if (((Button)sender).Tag.GetType() == typeof(Preset))
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
            else if (int.TryParse(destBtn.Tag.ToString(), out notUsedPri))
            {
                Console.WriteLine("Above unused!");

                if (e.Data.GetDataPresent(typeof(Preset)))
                {
                    Preset draggedPreset = (Preset)e.Data.GetData(typeof(Preset));
                    ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).BeginEdit();
                    ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).PresetPriority = notUsedPri;
                    ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).EndEdit();

                    //draggedPreset.Data.CurrentPresetData.BeginEdit();
                    //draggedPreset.Data.CurrentPresetData.PresetPriority = notUsedPri;
                    //draggedPreset.Data.CurrentPresetData.EndEdit();
                    ParentForm.presetMasterBindingSource.RaiseListChangedEvents = false;
                    ParentForm.presetMasterBindingSource.EndEdit();
                    ParentForm.presetMasterBindingSource.RaiseListChangedEvents = true;

                    if (ParentForm.tableAdapterManager.UpdateAll(ParentForm.jartrekDataSet) > 0)
                    {
                        ComposePriority(draggedPreset.KeyCode);

                    }
                }
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
            var data = e.Data.GetData(typeof(Preset));//can check for bound treenode here...

            bool thisIsAdequate = e.Data.GetDataPresent("Preset_Maintenance.Preset", false);

            originalPriority = ((Preset)data).Priority;

            if (int.TryParse(((Button)sender).Tag.ToString(), out potentialPriority))//if button is not in use...
            {
                Console.WriteLine($"Beginning Drag Enter on Position: {potentialPriority}");//parse out the tag if not used.. other than that, its a preset

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
            //Point point = (sender as Button).PointToClient(new Point(e.X, e.Y));//Not sure if i know what to do with this yet...
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

        internal void RandomizePriority()
        {
            var cm = (CurrencyManager)ParentForm.BindingContext[ParentForm.presetMasterBindingSource.DataSource, "PresetMaster"];

            Random rand = new Random();
            string key = null;
            foreach (PresetButton btn in PriorityButtons)
            {
                if (btn.Main_Button.Tag.GetType() != typeof(Preset))
                    continue;
                if (key == null)
                    key = (string)((Preset)btn.Main_Button.Tag).KeyCode;
                ((Preset)btn.Main_Button.Tag).Data.CurrentPresetData.BeginEdit();
                ((Preset)btn.Main_Button.Tag).Data.CurrentPresetData.PresetColor = rand.Next(1, 17);
                ((Preset)btn.Main_Button.Tag).Data.CurrentPresetData.ItemArray[4] = rand.Next(1, 30);


                //((Preset)btn.Main_Button.Tag).Data.CurrentPresetData.PresetPriority = rand.Next(1, 30);
                ((Preset)btn.Main_Button.Tag).Data.CurrentPresetData.EndEdit();
                if (((Preset)btn.Main_Button.Tag).Data.CurrentPresetData.RowState == DataRowState.Modified)
                {
                    Console.WriteLine("Modified!");

                }
            }
            // ParentForm.presetMasterBindingSource.EndEdit();
            if (ParentForm.tableAdapterManager.UpdateAll(ParentForm.jartrekDataSet) > 0)
            {
                MessageBox.Show("Success!");
                ComposePriority();


            }
        }
    }
}