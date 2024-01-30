using static JugendSpracheZählerUI.Model.CounterModel;

namespace JugendSpracheZählerUI
{
    public partial class SettingsWindow : Form
    {
        Main_Application main_Application = new();
        public SettingsWindow()
        {
            InitializeComponent();         
            SettingsText_Label.Text = Constants.Constants.Settings;
            LocalPath_Label.Text = Constants.Constants.LocalPathText;
        }

        private void CloseSettingsWindow_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main_Application.Show();
        }

        private void OutputData_Button_Click(object sender, EventArgs e)
        {
            OutputDataInSpecificFormat ouputData = new();
            this.Hide();
            ouputData.Show();
        }

        public void CheckActiveRadioButton()
        {
            if(OneButtonOnTheMainWindow_RadioButton.Checked)
            {
                CounterForRadioButtons = 1;
            }
            if (TwoButtonOnTheMainWindow_RadioButton.Checked)
            {
                CounterForRadioButtons = 2;
            }
            if (ThreeButtonOnTheMainWindow_RadioButton.Checked)
            {
                CounterForRadioButtons = 3;
            }
        }

        private void TwoButtonOnTheMainWindow_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TwoButtonOnTheMainWindow_RadioButton.Checked)
            {
                main_Application.EnableButtonForTwoWords();
                TwoButtonOnTheMainWindow_RadioButton.Checked = true;
            }
        }

        private void OneButtonOnTheMainWindow_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OneButtonOnTheMainWindow_RadioButton.Checked)
            {
                main_Application.EnableButtonForOneWord();
                OneButtonOnTheMainWindow_RadioButton.Checked = true;

            }
        }

        private void ThreeButtonOnTheMainWindow_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ThreeButtonOnTheMainWindow_RadioButton.Checked)
            {
                main_Application.EnabelButtonsForThreeWords();
                ThreeButtonOnTheMainWindow_RadioButton.Checked = true;
            }
        }

        private void CostumizeButtons_Button_Click(object sender, EventArgs e)
        {
            CheckActiveRadioButton();
            CostumizeButtons costumizeButtons = new();
            costumizeButtons.Show();
        }

        public void SetRadioButtonToTheRightValue()
        {
            if (CounterForRadioButtons == 1)
            {
                OneButtonOnTheMainWindow_RadioButton.Checked = true;
            }
            if (CounterForRadioButtons == 2)
            {
                TwoButtonOnTheMainWindow_RadioButton.Checked = true;
            }
            if (CounterForRadioButtons == 3)
            {
                ThreeButtonOnTheMainWindow_RadioButton.Checked = true;
            }
        }
    }
}