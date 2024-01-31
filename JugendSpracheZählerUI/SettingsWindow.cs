namespace JugendSpracheZählerUI
{
    public partial class SettingsWindow : Form
    {
        public string FilePath {  get; private set; }
        public SettingsWindow()
        {
            InitializeComponent();
            SettingsText_Label.Text = Constants.Constants.Settings;
            LocalPath_Label.Text = Constants.Constants.LocalPathText;
        }

        private void CloseSettingsWindow_Button_Click(object sender, EventArgs e)
        {
            Main_Application main_Application = new();
            this.Hide();
            main_Application.Show();
        }

        private void OutputData_Button_Click(object sender, EventArgs e)
        {
            OutputDataInSpecificFormat ouputData = new();
            this.Hide();
            ouputData.Show();
        }
    }
}