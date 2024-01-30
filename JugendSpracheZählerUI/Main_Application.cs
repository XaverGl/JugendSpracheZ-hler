namespace JugendSpracheZählerUI
{
    public partial class Main_Application : Form
    {
        private int wordCounter;
        private HttpClient client = new();
        SettingsWindow settingsWindow = new();
        SortedList<DateTime, string> wordsSinceLastPost = new();

        public Main_Application()
        {
            InitializeComponent();
            CountHigher_Button.Text = "Higher";
            CountLower_Button.Text = "Lower";
            OpenSettings_Button.Text = "Settings";
            Counter_Label.Text = "Entrys";
            SaveAndLoadIntoAFile_Button.Text = "SaveAndLoadIntoAFile";
        }

        public async void SetCounter()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7227/api/v1/zeiterfassung/GetCounter");
            var response = await client.SendAsync(request);


            if (response.IsSuccessStatusCode)
            {
                wordCounter = int.Parse(response.Content.ReadAsStringAsync().Result.ToString());
            }
            else
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseApplication_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenSettings_Button_Click(object sender, EventArgs e)
        {
            settingsWindow.Show();
            this.Hide();
        }

        private void CountHigher_Button_Click(object sender, EventArgs e)
        {
            wordCounter++;
            wordsSinceLastPost.Add(DateTime.Now, "");
        }

        private void CountLower_Button_Click(object sender, EventArgs e)
        {
            wordCounter--;
            wordsSinceLastPost.RemoveAt(wordsSinceLastPost.Count - 1);
        }

        private void SaveAndLoadIntoAFile_Button_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        private async void WriteFile()
        {
            StringContent httpContent = new StringContent(string.Join(",", wordsSinceLastPost.Select(x => $"{x.Key}:{x.Value}")));

            var response = await client.PostAsync("https://localhost:7227/api/v1/zeiterfassung/writeFile", httpContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Data was succesful uploaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Data upload failed {response.Content.ReadAsStringAsync().Result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}