using JugendSpracheZählerUI.Constants;

namespace JugendSpracheZählerUI
{
    public partial class OutputDataInSpecificFormat : Form
    {
        public OutputDataInSpecificFormat()
        {
            InitializeComponent();
            SetLabelAndTextBoxTextForMultipleDays();
        }

        private void CloseOutputDataWindow_Button_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            this.Dispose();
            settingsWindow.Show();
        }

        private void SpecificTime_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SpecificTime_RadioButton.Checked)
            {
                SetLabelAndTextBoxTextForMultipleDays();
                
            }    
            if(OnlyOneDay_RadioButton.Checked)
            {
                SetLabelAndTextBoxTextForOnlyOneDayOutput();
            }
        }

        public void SetLabelAndTextBoxTextForMultipleDays()
        {
            StartDate_Label.Text = Constants.Constants.StartDateText;
            StartDay_TextBox.Text = Constants.Constants.FormatWithText;
            EndDateOfWeek_Label.Text = Constants.Constants.EndDateText;
            EndDate_TextBox.Text = Constants.Constants.FormatWithText;
            EndDateOfWeek_Label.Visible = true;
            EndDate_TextBox.Visible = true;
        }

        public void SetLabelAndTextBoxTextForOnlyOneDayOutput()
        {
            StartDate_Label.Text = Constants.Constants.DateForOneOutputFile;
            StartDay_TextBox.Text = Constants.Constants.FormatWithText;
            EndDateOfWeek_Label.Visible = false;
            EndDate_TextBox.Visible = false;
        }
    }
}