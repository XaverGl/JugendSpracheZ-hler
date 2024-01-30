using static JugendSpracheZählerUI.Model.CounterModel;

namespace JugendSpracheZählerUI
{
    public partial class CostumizeButtons : Form
    {
        public CostumizeButtons()
        {
            InitializeComponent();
            CostumizeButtonsText_Label.Text = Constants.Constants.CostumizeButtons;
            SetTextForTheRadioButtons();
        }

        public void SetTextForTheRadioButtons()
        {
            if (CounterForRadioButtons == 1)
            {
                OneButtonIsActive_RadioButton.Checked = true;
                OneButtonIsActive_RadioButton.Visible = true;
                TwoButtonsAreActive_RadioButton.Visible = false;
                ThreeButtonsAreActive_RadioButtons.Visible = false;
                OneButtonIsActive_RadioButton.Text = "Middle Button";
            }
            if (CounterForRadioButtons == 2)
            {
                OneButtonIsActive_RadioButton.Checked = true;
                OneButtonIsActive_RadioButton.Visible = true;
                TwoButtonsAreActive_RadioButton.Visible = true;
                ThreeButtonsAreActive_RadioButtons.Visible = false;
                OneButtonIsActive_RadioButton.Text = "Left Button";
                TwoButtonsAreActive_RadioButton.Text = "Right Button";
            }
            if (CounterForRadioButtons == 3)
            {
                OneButtonIsActive_RadioButton.Checked = true;
                OneButtonIsActive_RadioButton.Visible = true;
                TwoButtonsAreActive_RadioButton.Visible = true;
                ThreeButtonsAreActive_RadioButtons.Visible = true;
                OneButtonIsActive_RadioButton.Text = "Left Button";
                TwoButtonsAreActive_RadioButton.Text = "Middle Button";
                ThreeButtonsAreActive_RadioButtons.Text = "Right Button";
            }
        }

        private void CloseApplication_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveCostumButtonNames_Button_Click(object sender, EventArgs e)
        {
            if(OneButtonIsActive_RadioButton.Text == "")
            {
                //implementation missing
            }
        }
    }
}