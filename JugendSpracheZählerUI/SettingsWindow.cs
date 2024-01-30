namespace JugendSpracheZählerUI
{
    public partial class SettingsWindow : Form
    {
        public string FilePath {  get; private set; }
        public SettingsWindow()
        {
            InitializeComponent();
            SettingsText_Label.Text = "Settings";
            LocalPath_Label.Text = "Local Path:";
        }

        private void CloseSettingsWindow_Button_Click(object sender, EventArgs e)
        {
            Main_Application main_Application = new();
            this.Hide();
            main_Application.Show();
        }
    }
}