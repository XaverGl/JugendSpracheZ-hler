using static JugendSpracheZählerUI.Model.CounterModel;

namespace JugendSpracheZählerUI
{
    public partial class Main_Application : Form
    {        
        public Main_Application()
        {
            InitializeComponent();
            OpenSettings_Button.Text = Constants.Constants.Settings;
            Counter_Label.Text = "Entrys";
            SaveAndLoadIntoAFile_Button.Text = "SaveAndLoadIntoAFile";
        }

        private void CloseApplication_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenSettings_Button_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new();
            settingsWindow.SetRadioButtonToTheRightValue();
            settingsWindow.Show();
            this.Hide();
        }

        public void EnableButtonForOneWord()
        {
            FirstWord_Button.Visible = false;
            SecondWord_Button.Visible= true;
            ThirdWord_Button.Visible = false;
            CounterForRadioButtons = 1;
        }

        public void EnableButtonForTwoWords()
        {
            FirstWord_Button.Visible = true;
            SecondWord_Button.Visible= false;
            ThirdWord_Button.Visible= true;
            CounterForRadioButtons = 2;
        }

        public void EnabelButtonsForThreeWords()
        {
            FirstWord_Button.Visible = true;
            SecondWord_Button.Visible= true;
            ThirdWord_Button.Visible= true; 
            CounterForRadioButtons = 3;
        }
    }
}