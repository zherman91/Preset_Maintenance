using Preset_Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public partial class PresetPriorityControl : UserControl
    {
        #region Variable Declarations

        Key.Preset[] Presets;

        const string originalLegend = "Not Used!";
        const int originalColor = -1;
        const string originalBitMap = "<None>";

        #endregion

        private static ToolTip toolTip = null;
        private Button originalButton;
        private Key.Preset newButton;

        StringBuilder str = null;

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
            int buttonName;
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
                buttonName = int.Parse(btn.Name.Substring(btn.Name.Length - 2, 2));
                btn.Main_Button.Tag = getIndex(buttonName);
            }
        }
        public Button GetPresetButton(Key.Preset preset, Button btn)
        {
            return ConvertToButton(preset, btn);
        }//this used to be PresetButton's... experimenting
        public void ResetPriority()
        {
            Console.WriteLine("Resetting Presets & Events...");

            foreach (PresetButton btn in PriorityButtons)//TODO: Could improve on this
            {
                btn.Main_Button.Text = originalLegend;
                btn.Main_Button.BackColor = default(Color);
                btn.Main_Button.Image = null;
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

        #endregion

        #region Private Methods

        public void ComposePriority(object item = null)
        {
            //need to clear the previous buttons..
            ResetPriority();
            AssignButtonTags();
            DataView presets = null;
            //TODO:Not yet implemented... //jartrekDataSet.GoToPriorDataTable go = null;
            //TODO: not yet implemented! //go = ParentForm.GoToPriorAdapter.GetGoToKeys((string)item);

            if (item != null)
            {
                //presets = ParentForm.presetMasterTableAdapter.GetPresetPriority((string)item);
                presets = (DataView)ParentForm.cm.List;
            }
            var buttons = PriorityButtons.ToDictionary((btn) => int.Parse(btn.Main_Button.Tag.ToString()));

            Presets = new Key.Preset[presets.Count];
            int index = 0;
            presets.Sort = "KeyCode";

            if (presets.Count == 0)
                return;
            ParentForm.presetMasterBindingSource.DataSource = presets;

            foreach (DataRowView row in presets.FindRows(item))//create preset objects!!!
            {
                Presets[index] = new Key.Preset((jartrekDataSet.PresetMasterRow)row.Row);//Grabs the entire row and becomes the preset data for this button.
                if (((jartrekDataSet.PresetMasterRow)row.Row).PresetPriority == 0)
                {
                    index++;
                    continue;
                }
                PresetButton btn = buttons[Presets[index].Priority];

                btn.Main_Button.Tag = Presets[index];
                index++;

                var VirtualPreset = ((Key.Preset)btn.Main_Button.Tag);

                if (VirtualPreset.Priority == ((jartrekDataSet.PresetMasterRow)row.Row).PresetPriority)
                {
                    btn.Main_Button.Text = VirtualPreset.Legend;
                    btn.Main_Button.BackColor = SetColor.GetColor((SetColor.JartrekColors)VirtualPreset.Color);
                    btn.Main_Button.Image = ParentForm.GetBitMaps(VirtualPreset.PresetCode, VirtualPreset.BitMap);
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
        private Button ConvertToButton(Key.Preset preset, Button destBtn)
        {
            Console.WriteLine("Converting To Button...");

            destBtn.Tag = (Key.Preset)preset;
            var presetInfo = (Key.Preset)destBtn.Tag;
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
            Button btn = ((Button)sender);
            Console.WriteLine($"{btn.Tag} Clicked!");



        }//Not working at the moment...

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Down!");
            originalButton = sender as Button;
            Key.Preset preset = originalButton.Tag as Key.Preset;

            //if (e.Button == MouseButtons.Right && originalButton.Tag.GetType() == typeof(Key.Preset))
            //{
            //    var btn = (sender as Button);
            //    preset = (Key.Preset)btn.Tag;
            //    ParentForm.DataBoundTree.TreeView.AfterSelect -= ParentForm.DataBoundTree_AfterSelect;
            //    ParentForm.DataBoundTree.TreeView.SelectedNode = ParentForm.DataBoundTree.SelectNode(preset.PresetCode, ParentForm.DataBoundTree.TreeView.Nodes);
            //    ParentForm.DataBoundTree.TreeView.AfterSelect += ParentForm.DataBoundTree_AfterSelect;

            //    ConfigureCurrents(preset);
            //}
            //else

            if (e.Button == MouseButtons.Left && originalButton.Tag.GetType() == typeof(Key.Preset))
            {
                ParentForm.DataBoundTree.TreeView.SelectedNode = ParentForm.DataBoundTree.SelectNode(preset.PresetCode, ParentForm.DataBoundTree.TreeView.Nodes);

                isMouseDown = true;
                DragDropEffects effect = originalButton.DoDragDrop(originalButton.Tag, DragDropEffects.All);
                isMouseDown = false;
                //handle original button here?
                if (effect == DragDropEffects.Move && originalButton.Tag != newButton)
                {
                    originalButton.Text = originalLegend;
                    originalButton.BackColor = default(Color);
                    originalButton.Image = null;
                    originalButton.UseVisualStyleBackColor = true;
                    originalButton.Tag = originalPriority;

                    //UNDONE
                }
                else if (effect == DragDropEffects.Scroll)
                {
                    originalButton.Text = originalLegend;
                    originalButton.BackColor = default(Color);
                    originalButton.Image = null;
                    originalButton.UseVisualStyleBackColor = true;
                    originalButton.Tag = originalPriority;
                    preset.Data.CurrentPresetData.BeginEdit();
                    preset.Priority = 0;
                    preset.Data.CurrentPresetData.EndEdit();
                    try
                    {
                        if (ParentForm.tableAdapterManager.UpdateAll(ParentForm.jartrekDataSet) > 0)
                            Console.WriteLine("Removed!");
                        ParentForm.RefreshNodeImages();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Error when updating presets!");

                    }
                }
            }
            //else
            //{
            //    Console.WriteLine("Button was not moved...");
            //    if (ParentForm.CurrentRow.IsNew)
            //    {
            //        int pri = (int)originalButton.Tag;
            //        ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).PresetPriority = pri;
            //    }
            //    else
            //    {
            //        int pri = (int)originalButton.Tag;
            //        ((jartrekDataSet.PresetMasterRow)ParentForm.CurrentRow.Row).PresetPriority = pri;
            //        ((DataRowView)ParentForm.CurrentRow).EndEdit();
            //    }
            //}
        }

        public void ConfigureCurrents(Key.Preset preset)
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
            ParentForm.CurrentPreset_Button.Tag = preset;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            str = null;
            str = new StringBuilder();
            string tempPreset = null;
            //string templateLab = "Modifier Preset: ";
            string[] mods = null;
            //int priority = 0;
            toolTip.Dispose();
            toolTip = new ToolTip();
            try
            {
                var preset = (btn.Tag as Key.Preset).Data.CurrentPresetData;
                CurrencyManager cm = (CurrencyManager)ParentForm.BindingContext[ParentForm.jartrekDataSet, "keymaster.mykeyrelate.presetmaster_modtemplate"];

                if (cm.List.Count != 0)
                {
                    tempPreset = ((jartrekDataSet.ModTemplateRow)((DataRowView)cm.Current).Row).TemplatePreset;
                    mods = new string[cm.List.Count];

                    int i = 0;
                    foreach (DataRowView drv in cm.List)
                    {
                        mods[i] = (string)((jartrekDataSet.ModTemplateRow)drv.Row).TemplateName;
                        i++;
                    }
                    //templateLab = "Template: ";
                }
                else
                {
                    CurrencyManager cm2 = (CurrencyManager)ParentForm.BindingContext[ParentForm.jartrekDataSet, "keymaster.mykeyrelate.presetmaster_modifier"];

                    if (cm2.List.Count > 0)
                    {
                        try
                        {
                            //templateLab = "Modifier Preset: ";
                            tempPreset = ((jartrekDataSet.ModifierRow)((DataRowView)cm2.Current).Row).ModifierPreset;//Modifier preset is the preset code for that modifier preset..
                            mods = new string[cm2.List.Count];
                            int i = 0;
                            foreach (DataRowView drv in cm2.List)
                            {
                                mods[i] = (string)((jartrekDataSet.ModifierRow)drv.Row).ModifierPreset;//modifier code is the preset code for that modifier.. 
                                i++;
                            }

                        }
                        catch (IndexOutOfRangeException o)
                        {
                            tempPreset = "No Modifiers for this Preset!";
                            Console.WriteLine("Problem with template index in mouse hover... " + o.Message);
                        }
                    }

                }
                //Console.WriteLine("Assigned Modifier Templates: ");

                str.Append("Assigned Modifiers: \n");
                if (mods != null)
                    for (int j = 0; j < mods.Length; j++) { str.Append("* " + mods[j] + "\n"); }

                str.Insert(0,

                    "Preset Code: " + preset.PresetCode + "\n" +
                    "PresetPriority: " + preset.PresetPriority + "\n"

                    );

                toolTip.SetToolTip(btn, str.ToString());
                toolTip.AutoPopDelay = 10000;
                toolTip.ToolTipIcon = ToolTipIcon.Info;
                toolTip.UseAnimation = true;
                toolTip.UseFading = true;
                toolTip.IsBalloon = true;
                toolTip.ShowAlways = true;


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

            Key.Preset currentData;

            var destBtn = ((Button)sender);
            currentData = (Key.Preset)e.Data.GetData("Preset_Maintenance.Preset");

            //should test for type of element first...

            if (((Button)sender).Tag.GetType() == typeof(Key.Preset))
            {
                if (e.Data.GetDataPresent("Preset_Maintenance.Preset", false))//data is a preset
                {
                    Point point = ((Button)sender).PointToClient(new Point(e.X, e.Y));
                    Button newPresetBtn = ConvertToButton(currentData, destBtn);

                    //printing out priority read from database...
                    Console.WriteLine("Priority from Preset object: " + ((Key.Preset)newPresetBtn.Tag).Data.CurrentPresetData.PresetPriority);

                    bool newSwap = PositionSwap(((Key.Preset)newPresetBtn.Tag), ((Key.Preset)destBtn.Tag));//we should just swap the entire button...
                }
            }
            else if (int.TryParse(destBtn.Tag.ToString(), out notUsedPri))
            {
                Console.WriteLine("Above unused!");

                if (e.Data.GetDataPresent(typeof(Key.Preset)))
                {
                    Key.Preset draggedPreset = (Key.Preset)e.Data.GetData(typeof(Key.Preset));

                    draggedPreset.Data.CurrentPresetData.BeginEdit();
                    draggedPreset.Priority = notUsedPri;
                    draggedPreset.Data.CurrentPresetData.EndEdit();

                    if (ParentForm.tableAdapterManager.UpdateAll(ParentForm.jartrekDataSet) > 0)//TODO: ADD TRY CATCH!
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
        private bool PositionSwap(Key.Preset sourcePreset, Key.Preset destPreset)
        {
            var sourcePri = ((Key.Preset)sourcePreset).Priority;//need the priority checked here...
            var destPri = ((Key.Preset)destPreset).Priority;

            Console.WriteLine($"Potential swap of Source: {sourcePri} Destination: {destPri}");


            return false;
        }//UNDONE

        private void Btn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            var data = e.Data.GetData(typeof(Key.Preset));//can check for bound treenode here...

            bool thisIsAdequate = e.Data.GetDataPresent("Preset_Maintenance.Preset", false);

            originalPriority = ((Key.Preset)data).Priority;

            if (int.TryParse(((Button)sender).Tag.ToString(), out potentialPriority))//if button is not in use...
            {
                Console.WriteLine($"Beginning Drag Enter on Position: {potentialPriority}");//parse out the tag if not used.. other than that, its a preset

            }
            else
            {//UNDONE:need to fix this.. the drag enter event goes off as soon as i click.. need to add a "threshold"
                //must be preset then
                //i now have access to the data row... Can be used to store a potential priority as well as if a swap must be performed...
                Console.WriteLine($"Preset Code: {((Key.Preset)data).PresetCode} Priority: {((Key.Preset)data).Priority}");//could a stack be used here?
                Console.WriteLine($"Currently Above: {((Key.Preset)((Button)sender).Tag).PresetCode} Position: {((Key.Preset)((Button)sender).Tag).Priority} ");
                newButton = ((Key.Preset)(sender as Button).Tag);
                newPriority = ((Key.Preset)((Button)sender).Tag).Priority;//gets the priority of the button below the cursor if it is of type Preset

            }
            //Point point = (sender as Button).PointToClient(new Point(e.X, e.Y));//Not sure if i know what to do with this yet...
        }

        private void PresetButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point newPoint = ((Button)sender).PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                //((Button)sender).Location = newPoint;
            }
        }

        private void PresetButton_DragOver(object sender, DragEventArgs e)
        {
            //var draggedPreset = e.Data.GetData("Preset_Maintenance.Preset", true);

            //var senderTag = ((Button)sender).Tag;

            //if (int.TryParse(senderTag.ToString(), out notUsedPri))
            //{
            //    Console.WriteLine($"Currently above position: {senderTag.ToString()}");
            //}
            //else if (senderTag.GetType() == typeof(Key.Preset))
            //{
            //    if (((Key.Preset)senderTag).PresetCode != ((Key.Preset)originalButton.Tag).PresetCode)
            //        Console.WriteLine($"Currently above: {((Key.Preset)senderTag).PresetCode}");

            //}
        }

        private void PresetButton_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        internal void RandomizePriority()
        {
            ParentForm.presetMasterBindingSource.RaiseListChangedEvents = false;
            ParentForm.DataBoundTree.TreeView.AfterSelect -= ParentForm.DataBoundTree_AfterSelect;
            ParentForm.DataBoundTree.handlerAfterSelect -= ParentForm.DataBoundTree.tv_AfterSelect;
            ParentForm.DataBoundTree.handlerListChanged -= ParentForm.DataBoundTree.cm_ListChanged;
            ParentForm.presetMasterBindingSource.PositionChanged -= ParentForm.presetMasterBindingSource_PositionChanged;

            Random rand = new Random();
            List<Key.Preset> presetList = new List<Key.Preset>();
            List<PresetButton> unused = new List<PresetButton>();

            foreach (PresetButton btn in PriorityButtons)
            {
                if (btn.Main_Button.Tag.GetType() == typeof(Key.Preset))
                {
                    presetList.Add(btn.Main_Button.Tag as Key.Preset);
                    unused.Add(btn);
                }
                else
                {
                    unused.Add(btn);
                }
            }

            presetList.Sort(delegate (Key.Preset p1, Key.Preset p2) { return p1.Description.CompareTo(p2.Description); });
            unused.Sort(delegate (PresetButton b1, PresetButton b2) { return (int)b1.Name.CompareTo(b2.Name); });

            for (int i = 0; i < presetList.Count; i++)
            {
                presetList[i].Priority = (i * 6) + 1;

                while (presetList[i].Priority > 30)
                    presetList[i].Priority -= 29;

            }

            if (ParentForm.tableAdapterManager.UpdateAll(ParentForm.jartrekDataSet) > 0)
            {
                Console.WriteLine("Successfully Ordered Priority!");
                ComposePriority(ParentForm.Key);
            }
            ParentForm.DataBoundTree.handlerListChanged += ParentForm.DataBoundTree.cm_ListChanged;
            ParentForm.DataBoundTree.handlerAfterSelect += ParentForm.DataBoundTree.tv_AfterSelect;
            ParentForm.presetMasterBindingSource.RaiseListChangedEvents = true;
            ParentForm.presetMasterBindingSource.PositionChanged += ParentForm.presetMasterBindingSource_PositionChanged;
            ParentForm.DataBoundTree.TreeView.AfterSelect += ParentForm.DataBoundTree_AfterSelect;

        }
    }
}