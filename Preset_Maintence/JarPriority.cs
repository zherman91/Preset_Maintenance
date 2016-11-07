using System;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    /// <summary>
    /// This class handles the positioning of the key or game on the screen 
    /// in order to complete the process of adding a game to the one and only, Jartrek. 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class JarPriority : Form
    {
        #region - Variable Declarations
        private jartrekDataSet.JarTypeDataDataTable _myJarTypeDataTable = new jartrekDataSet.JarTypeDataDataTable();
        private jartrekDataSetTableAdapters.JarTypeDataTableAdapter _myJarTypeTableAdapter = new jartrekDataSetTableAdapters.JarTypeDataTableAdapter();

        private jartrekDataSetTableAdapters.KeyMasterDataAdapter _myKeyMasterDataAdapter = new jartrekDataSetTableAdapters.KeyMasterDataAdapter();
        private jartrekDataSet.KeyMasterDataDataTable _myKeyMasterDataTable = new jartrekDataSet.KeyMasterDataDataTable();

        private static string[,] _keyPri2d;
        private static string[,] _jarPri2d;

        public static int[] jarColorArray;
        public static string formNumber;
        public static string jarLegend;
        public static int btnClicked;
        public static int finalPriority;
        public static int currentGamePriority;
        public static int priorityChosen;
        public static Color randomColor = SetColor.GetNewJarColor();
        public int randomColorValue = new Random().Next(1, 17);
        public Color prevColor = Color.Silver;

        int timesClicked = 0;
        public int rowCount = 0;
        public int jarRowCount = 0;

        public static DataRow[] jarLogRowArray;
        public static DataRow[] jarTrekRowArray;
        private DataView _jarTrekDataView;

        public Button[] btnArray;
        public int currentScreenPosition;
        private static int _currentJarColor;
        public static Color currentlySetColor = Color.Silver;

        public bool inJarTrek { get { return true; } }
        public int currentJarColor { get { return _currentJarColor; } set { _currentJarColor = value; } }
        public int currentScreen { get { return currentScreenPosition; } set { currentScreenPosition = value; } }
        #endregion

        public delegate int buttonClicked(Object sender, EventArgs e);

        /// <summary>
        /// Initializes a new instance of the <see cref="JarPriority"/> class.
        /// </summary>
        public JarPriority()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Loaded event of the Form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form_Loaded(object sender, EventArgs e)
        {
            #region - Huge Freaking Button Array -
            btnArray = new Button[100] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
                               button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
                               button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
                               button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
                               button41, button42, button43, button44, button45, button46, button47, button48, button49, button50,
                               button51, button52, button53, button54, button55, button56, button57, button58, button59, button60,
                               button61, button62, button63, button64, button65, button66, button67, button68, button69, button70,
                               button71, button72, button73, button74, button75, button76, button77, button78, button79, button80,
                               button81, button82, button83, button84, button85, button86, button87, button88, button89, button90,
                               button91, button92, button93, button94, button95, button96, button97, button98, button99, button100 };
            #endregion

            _myJarTypeTableAdapter.FillReqData(_myJarTypeDataTable);
            _myKeyMasterDataAdapter.FillKeyMasterData(_myKeyMasterDataTable);
            jarRowCount = _myJarTypeDataTable.Rows.Count;

            if (currentScreenPosition > 0) tab_panel.SelectedIndex = currentScreenPosition - 1;

            string expression = String.Format($"JarType = '{formNumber}'");
            _jarTrekDataView = _myJarTypeDataTable.AsDataView();
            _jarTrekDataView.RowFilter = expression;

            jarTrekRowArray = _myJarTypeDataTable.Select(expression);

            getKeyPriority();//-> getJarPriority();
            setKeyText();//-> setJarText();
            AssignClickEvent();

            if (currentGamePriority > 0)
            {
                int priorityIndex = currentGamePriority - 1;
                btnArray[priorityIndex].Text = "Current Location";
                btnArray[priorityIndex].BackColor = Color.Silver;
                btnArray[priorityIndex].UseVisualStyleBackColor = true;
            }
        }
        /// <summary>
        /// Gets the key priority.
        /// </summary>
        public void getKeyPriority()
        {
            rowCount = _myKeyMasterDataTable.Rows.Count;

            _keyPri2d = new string[rowCount, 2];

            for (int k = 0; k < _keyPri2d.GetLength(0); k++)
            {
                _keyPri2d[k, 0] = _myKeyMasterDataTable.Rows[k]["KeyPriority"].ToString();
            }
            for (int l = 0; l < _keyPri2d.GetLength(0); l++)
            {
                _keyPri2d[l, 1] = _myKeyMasterDataTable.Rows[l]["KeyLegend"].ToString();
            }
            getJarPriority();
        }
        /// <summary>
        /// Gets the jar priority.
        /// </summary>
        public void getJarPriority()
        {
            _jarPri2d = new string[jarRowCount, 2];
            jarColorArray = new int[_jarPri2d.Length];

            try
            {
                for (int i = 0; i < _jarPri2d.GetLength(0); i++)
                {
                    _jarPri2d[i, 0] = _myJarTypeDataTable.Rows[i]["Priority"].ToString();
                }
                for (int j = 0; j < _jarPri2d.GetLength(0); j++)
                {
                    _jarPri2d[j, 1] = _myJarTypeDataTable.Rows[j]["JarLegend"].ToString();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                if (_jarPri2d.GetLength(0) == 0)
                {
                    Console.WriteLine("There are no games on the screen!");
                }
                Console.WriteLine(e.Message + "Error found in getJarPriority Method!");
            }
        }
        /// <summary>
        /// Sets the key text.
        /// </summary>
        private void setKeyText()
        {
            try
            {
                for (int i = 0; i < _myKeyMasterDataTable.Rows.Count; i++)
                {
                    Button myBtn = btnArray[Int32.Parse(_keyPri2d[i, 0].ToString())];
                    myBtn.Text = _myKeyMasterDataTable.Rows[i]["KeyLegend"].ToString();
                    myBtn.BackColor = SetColor.GetColor((SetColor.JartrekColors)_myKeyMasterDataTable.Rows[i]["KeyColor"]);//eliminated SetKeyColorMethod!
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " Somethings going wrong with setKeyText Method. ");
            }
        }
        /// <summary>
        /// Sets the jar text.
        /// </summary>
        private void setJarText()
        {
            try
            {
                for (int i = 0; i < _jarPri2d.GetLength(0); i++)
                {
                    int btnIndex = Int32.Parse(_jarPri2d[i, 0].ToString()) - 1;
                    if (btnIndex >= 0 && btnIndex < 101)
                    {
                        Button myBtn = btnArray[btnIndex];
                        myBtn.Text = _myJarTypeDataTable.Rows[i]["JarLegend"].ToString();
                        myBtn.BackColor = SetColor.GetColor((SetColor.JartrekColors)_myJarTypeDataTable.Rows[i]["JarColor"]);
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " Somethings not right with setJarText method.");
            }
        }
        /// <summary>
        /// Method to display the proper data retrieved from database per form number.
        /// </summary>
        /// <param name="btn">The BTN.</param>
        public void SetButtonData(Button btn)
        {
            int colorUpdated;
            int priorUpdated;
            int jarLogColor;
            int jarTrekColor = -1;
            bool inJarTrek = false;
            _myJarTypeTableAdapter.FillReqData(_myJarTypeDataTable);
            string expression = String.Format($"JarType = '{formNumber}'");
            _jarTrekDataView = _myJarTypeDataTable.AsDataView();
            _jarTrekDataView.RowFilter = expression;

            jarTrekRowArray = _myJarTypeDataTable.Select(expression);
            bool found = jarTrekRowArray.Length != 0;
            int currentJarPriority = -1;

            bool inJarLog = Int32.TryParse(jarLogRowArray[0].ItemArray[1].ToString(), out jarLogColor);
            if (found)
                inJarTrek = Int32.TryParse(jarTrekRowArray[0].ItemArray[1].ToString(), out jarTrekColor);

            if (inJarTrek)
            {
                if (Int32.TryParse(jarTrekRowArray[0].ItemArray[3].ToString(), out currentJarPriority))
                {
                    if (currentJarPriority > 0)
                    {
                        priorUpdated = _myJarTypeTableAdapter.UpdatePriority(finalPriority, formNumber);
                        colorUpdated = _myJarTypeTableAdapter.UpdateJarColor(timesClicked == 1 ? jarTrekColor : timesClicked, formNumber);
                        currentJarColor = timesClicked == 1 ? jarTrekColor : timesClicked;
                        if (priorUpdated > 0 && colorUpdated > 0)
                        {
                            Console.WriteLine("Color and priority updated!");
                        }
                        if (currentJarPriority == finalPriority)
                        {
                            MessageBox.Show("Jar position not updated! Game was not moved. Try clicking a different spot next time if this was unintentional.", "Button Priority Equal!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        int jarColorUpdated = _myJarTypeTableAdapter.UpdateJarColor(timesClicked == 1 ? jarTrekColor : timesClicked, formNumber);
                        int jarPriorityUpdated = _myJarTypeTableAdapter.UpdatePriority(finalPriority, formNumber);
                        currentJarColor = timesClicked == 1 ? jarTrekColor : timesClicked;
                        Console.WriteLine("JarColor changed on  " + jarColorUpdated + " Rows\nJarPriority changed on " + jarPriorityUpdated + " Rows");
                    }
                }
            }
            else
            {
                if (Int32.TryParse(jarLogRowArray[0].ItemArray[1].ToString(), out jarLogColor))
                {
                    if (jarLogColor == 0 || timesClicked > 1)
                    {
                        currentJarColor = timesClicked;
                    }
                    else
                    {
                        currentJarColor = jarLogColor;
                    }
                }
                else
                {
                    MessageBox.Show("Could not find this game!");
                }
            }
        }
        /// <summary>
        /// Prints the arrays.
        /// </summary>
        public static void PrintArrays()
        {
            Console.WriteLine("Now printing the key priority 2d array: ");
            try
            {
                for (int k = 0; k < _keyPri2d.GetLength(0); k++)
                {
                    Console.WriteLine(_keyPri2d[k, 0].ToString() + "\t | " + _keyPri2d[k, 1].ToString());
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + " There are no keys on the screen!");
            }

            Console.WriteLine("Now printing the Jar Priorities from jarPri2d: ");
            try
            {
                for (int j = 0; j < _jarPri2d.GetLength(0); j++)
                {
                    Console.WriteLine(_jarPri2d[j, 0].ToString() + "\t | " + _jarPri2d[j, 1].ToString());
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "There are no games on the screen!");

            }
        }
        /// <summary>
        /// Assigns the click event to each button in the button[]
        /// </summary>
        public void AssignClickEvent()
        {
            for (int i = 0; i < btnArray.Length; i++)
            {
                if (btnArray[i].Text == "Not Used!")
                {
                    btnArray[i].Font = new Font(Font, FontStyle.Bold);
                }
                //it's important to have this; closing over the loop variable would be bad
                int index = i;
                btnArray[i].Click += (sender, args) => ButtonClicked(btnArray[index], index);
            }
        }
        /// <summary>
        /// Buttons the clicked.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="index">The index.</param>
        private void ButtonClicked(Button button, int index)
        {
            if (button.Text == "Not Used!" || button.Text == "Current Location")
            {
                timesClicked = 1;
                if (btnClicked == 0) btnClicked = index;
                btnArray[btnClicked].Text = "Not Used!";
                btnArray[btnClicked].BackColor = prevColor;
                btnArray[btnClicked].UseVisualStyleBackColor = false;
                button.Text = jarLegend;
                // button.BackColor = _currentColor;
                btnClicked = index;
            }
            else if (button.Text == jarLegend)
            {
                if (timesClicked > 17) timesClicked = 1;
                timesClicked++;
                button.BackColor = SetColor.GetColor((SetColor.JartrekColors)timesClicked);
            }
            else
            {
                MessageBox.Show("This button is already in use!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the Click event of the confirm_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rightArrow_Button_Click(object sender, EventArgs e)
        {
            int currentScreen = tab_panel.SelectedIndex;

            switch (currentScreen)
            {
                case 0:
                    tab_panel.SelectTab(1);
                    break;
                case 1:
                    tab_panel.SelectTab(2);
                    break;
                case 2:
                    tab_panel.SelectTab(3);
                    break;
                case 3:
                    tab_panel.SelectTab(4);
                    break;
            }
        }
        private void leftArrow_Button_Click(object sender, EventArgs e)
        {
            int currentScreen = tab_panel.SelectedIndex;

            switch (currentScreen)
            {
                case 1:
                    tab_panel.SelectTab(0);
                    break;
                case 2:
                    tab_panel.SelectTab(1);
                    break;
                case 3:
                    tab_panel.SelectTab(2);
                    break;
                case 4:
                    tab_panel.SelectTab(3);
                    break;
            }
        }
    }

    public static class SetColor
    {
        [Flags]
        public enum JartrekColors { RegisterDefault = 0, Red = 1, Green = 2, Yellow = 3, Blue = 4, Magenta = 5, Cyan = 6, White = 7, Beige = 8, Goldenrod = 9, Khaki = 10, Plum = 11, Orange = 12, PaleGreen = 13, Pink = 14, Salmon = 15, Sienna = 16, Tan = 17 };
        public static Color GetColor(JartrekColors keyColor)
        {
            Color currentColor = Color.Silver;

            switch (keyColor)
            {
                case JartrekColors.Red:
                    currentColor = Color.Red;
                    break;
                case JartrekColors.Green:
                    currentColor = Color.Lime;
                    break;
                case JartrekColors.Yellow:
                    currentColor = Color.Yellow;
                    break;
                case JartrekColors.Blue:
                    currentColor = Color.Blue;
                    break;
                case JartrekColors.Magenta:
                    currentColor = Color.Fuchsia;
                    break;
                case JartrekColors.Cyan:
                    currentColor = Color.Aqua;
                    break;
                case JartrekColors.White:
                    currentColor = Color.White;
                    break;
                case JartrekColors.Beige:
                    currentColor = Color.Beige;
                    break;
                case JartrekColors.Goldenrod:
                    currentColor = Color.Goldenrod;
                    break;
                case JartrekColors.Khaki:
                    currentColor = Color.Khaki;
                    break;
                case JartrekColors.Plum:
                    currentColor = Color.Plum;
                    break;
                case JartrekColors.Orange:
                    currentColor = Color.Orange;
                    break;
                case JartrekColors.PaleGreen:
                    currentColor = Color.PaleGreen;
                    break;
                case JartrekColors.Pink:
                    currentColor = Color.Pink;
                    break;
                case JartrekColors.Salmon:
                    currentColor = Color.Salmon;
                    break;
                case JartrekColors.Sienna:
                    currentColor = Color.Sienna;
                    break;
                case JartrekColors.Tan:
                    currentColor = Color.Tan;
                    break;
                default: return currentColor;
            }
            return currentColor;
        }
        public static int GetColorInt(JartrekColors keyColor)
        {
            Color currentColor = Color.Silver;
            int colorInt = 1;
            switch (keyColor)
            {
                case JartrekColors.Red:
                    currentColor = Color.Red;
                    colorInt = 1;
                    break;
                case JartrekColors.Green:
                    currentColor = Color.Lime;
                    colorInt = 2;
                    break;
                case JartrekColors.Yellow:
                    currentColor = Color.Yellow;
                    colorInt = 3;
                    break;
                case JartrekColors.Blue:
                    currentColor = Color.Blue;
                    colorInt = 4;
                    break;
                case JartrekColors.Magenta:
                    currentColor = Color.Fuchsia;
                    colorInt = 5;
                    break;
                case JartrekColors.Cyan:
                    currentColor = Color.Aqua;
                    colorInt = 6;
                    break;
                case JartrekColors.White:
                    currentColor = Color.White;
                    colorInt = 7;
                    break;
                case JartrekColors.Beige:
                    currentColor = Color.Beige;
                    colorInt = 8;
                    break;
                case JartrekColors.Goldenrod:
                    currentColor = Color.Goldenrod;
                    colorInt = 9;
                    break;
                case JartrekColors.Khaki:
                    currentColor = Color.Khaki;
                    colorInt = 10;
                    break;
                case JartrekColors.Plum:
                    currentColor = Color.Plum;
                    colorInt = 11;
                    break;
                case JartrekColors.Orange:
                    currentColor = Color.Orange;
                    colorInt = 12;
                    break;
                case JartrekColors.PaleGreen:
                    currentColor = Color.PaleGreen;
                    colorInt = 13;
                    break;
                case JartrekColors.Pink:
                    currentColor = Color.Pink;
                    colorInt = 14;
                    break;
                case JartrekColors.Salmon:
                    currentColor = Color.Salmon;
                    colorInt = 15;
                    break;
                case JartrekColors.Sienna:
                    currentColor = Color.Sienna;
                    colorInt = 16;
                    break;
                case JartrekColors.Tan:
                    currentColor = Color.Tan;
                    colorInt = 17;
                    break;
                default: return colorInt;
            }
            return colorInt;
        }
        public static Color GetNewJarColor()
        {
            int randomColorValue = new Random().Next(1, 17);
            Color currentColor = SetColor.GetColor((SetColor.JartrekColors)randomColorValue);

            return currentColor;
        }
    }
}
