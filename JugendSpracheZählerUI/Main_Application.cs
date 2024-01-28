namespace JugendSpracheZählerUI
{
    public partial class Main_Application : Form
    {
        public Main_Application()
        {
            InitializeComponent();
            CountHigher_Button.Text = "Higher";
            CountLower_Button.Text = "Lower";
            OpenSettings_Button.Text = "Settings";
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
            settingsWindow.Show();
            this.Hide();
        }
    }
}