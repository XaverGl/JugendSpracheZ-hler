namespace JugendSpracheZählerUI
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SettingsText_Label = new Label();
            CloseSettingsWindow_Button = new Button();
            LocalPath_Label = new Label();
            LocaltPathEntry_TextBox = new TextBox();
            OutputData_Button = new Button();
            label1 = new Label();
            OneButtonOnTheMainWindow_RadioButton = new RadioButton();
            TwoButtonOnTheMainWindow_RadioButton = new RadioButton();
            ThreeButtonOnTheMainWindow_RadioButton = new RadioButton();
            CostumizeButtons_Button = new Button();
            SuspendLayout();
            // 
            // SettingsText_Label
            // 
            SettingsText_Label.AutoSize = true;
            SettingsText_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsText_Label.ForeColor = Color.White;
            SettingsText_Label.Location = new Point(12, 9);
            SettingsText_Label.Name = "SettingsText_Label";
            SettingsText_Label.Size = new Size(17, 21);
            SettingsText_Label.TabIndex = 0;
            SettingsText_Label.Text = "x";
            // 
            // CloseSettingsWindow_Button
            // 
            CloseSettingsWindow_Button.BackColor = Color.FromArgb(192, 0, 0);
            CloseSettingsWindow_Button.FlatStyle = FlatStyle.Popup;
            CloseSettingsWindow_Button.ForeColor = Color.Black;
            CloseSettingsWindow_Button.Location = new Point(473, 12);
            CloseSettingsWindow_Button.Name = "CloseSettingsWindow_Button";
            CloseSettingsWindow_Button.Size = new Size(30, 30);
            CloseSettingsWindow_Button.TabIndex = 4;
            CloseSettingsWindow_Button.Text = "X";
            CloseSettingsWindow_Button.UseVisualStyleBackColor = false;
            CloseSettingsWindow_Button.Click += CloseSettingsWindow_Button_Click;
            // 
            // LocalPath_Label
            // 
            LocalPath_Label.AutoSize = true;
            LocalPath_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocalPath_Label.ForeColor = Color.White;
            LocalPath_Label.Location = new Point(59, 67);
            LocalPath_Label.Name = "LocalPath_Label";
            LocalPath_Label.Size = new Size(17, 21);
            LocalPath_Label.TabIndex = 5;
            LocalPath_Label.Text = "x";
            // 
            // LocaltPathEntry_TextBox
            // 
            LocaltPathEntry_TextBox.Location = new Point(149, 65);
            LocaltPathEntry_TextBox.Name = "LocaltPathEntry_TextBox";
            LocaltPathEntry_TextBox.Size = new Size(100, 23);
            LocaltPathEntry_TextBox.TabIndex = 6;
            // 
            // OutputData_Button
            // 
            OutputData_Button.Location = new Point(334, 67);
            OutputData_Button.Name = "OutputData_Button";
            OutputData_Button.Size = new Size(100, 23);
            OutputData_Button.TabIndex = 7;
            OutputData_Button.Text = "Output Data";
            OutputData_Button.UseVisualStyleBackColor = true;
            OutputData_Button.Click += OutputData_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 8;
            label1.Text = "How many Buttons?";
            // 
            // OneButtonOnTheMainWindow_RadioButton
            // 
            OneButtonOnTheMainWindow_RadioButton.AutoSize = true;
            OneButtonOnTheMainWindow_RadioButton.ForeColor = Color.White;
            OneButtonOnTheMainWindow_RadioButton.Location = new Point(167, 118);
            OneButtonOnTheMainWindow_RadioButton.Name = "OneButtonOnTheMainWindow_RadioButton";
            OneButtonOnTheMainWindow_RadioButton.Size = new Size(31, 19);
            OneButtonOnTheMainWindow_RadioButton.TabIndex = 9;
            OneButtonOnTheMainWindow_RadioButton.Text = "1";
            OneButtonOnTheMainWindow_RadioButton.UseVisualStyleBackColor = true;
            OneButtonOnTheMainWindow_RadioButton.CheckedChanged += OneButtonOnTheMainWindow_RadioButton_CheckedChanged;
            // 
            // TwoButtonOnTheMainWindow_RadioButton
            // 
            TwoButtonOnTheMainWindow_RadioButton.AutoSize = true;
            TwoButtonOnTheMainWindow_RadioButton.ForeColor = Color.White;
            TwoButtonOnTheMainWindow_RadioButton.Location = new Point(167, 143);
            TwoButtonOnTheMainWindow_RadioButton.Name = "TwoButtonOnTheMainWindow_RadioButton";
            TwoButtonOnTheMainWindow_RadioButton.Size = new Size(31, 19);
            TwoButtonOnTheMainWindow_RadioButton.TabIndex = 10;
            TwoButtonOnTheMainWindow_RadioButton.Text = "2";
            TwoButtonOnTheMainWindow_RadioButton.UseVisualStyleBackColor = true;
            TwoButtonOnTheMainWindow_RadioButton.CheckedChanged += TwoButtonOnTheMainWindow_RadioButton_CheckedChanged;
            // 
            // ThreeButtonOnTheMainWindow_RadioButton
            // 
            ThreeButtonOnTheMainWindow_RadioButton.AutoSize = true;
            ThreeButtonOnTheMainWindow_RadioButton.Checked = true;
            ThreeButtonOnTheMainWindow_RadioButton.ForeColor = Color.White;
            ThreeButtonOnTheMainWindow_RadioButton.Location = new Point(167, 168);
            ThreeButtonOnTheMainWindow_RadioButton.Name = "ThreeButtonOnTheMainWindow_RadioButton";
            ThreeButtonOnTheMainWindow_RadioButton.Size = new Size(31, 19);
            ThreeButtonOnTheMainWindow_RadioButton.TabIndex = 11;
            ThreeButtonOnTheMainWindow_RadioButton.TabStop = true;
            ThreeButtonOnTheMainWindow_RadioButton.Text = "3";
            ThreeButtonOnTheMainWindow_RadioButton.UseVisualStyleBackColor = true;
            ThreeButtonOnTheMainWindow_RadioButton.CheckedChanged += ThreeButtonOnTheMainWindow_RadioButton_CheckedChanged;
            // 
            // CostumizeButtons_Button
            // 
            CostumizeButtons_Button.Location = new Point(262, 139);
            CostumizeButtons_Button.Name = "CostumizeButtons_Button";
            CostumizeButtons_Button.Size = new Size(108, 23);
            CostumizeButtons_Button.TabIndex = 12;
            CostumizeButtons_Button.Text = "Costumize...";
            CostumizeButtons_Button.UseVisualStyleBackColor = true;
            CostumizeButtons_Button.Click += CostumizeButtons_Button_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(515, 273);
            Controls.Add(CostumizeButtons_Button);
            Controls.Add(ThreeButtonOnTheMainWindow_RadioButton);
            Controls.Add(TwoButtonOnTheMainWindow_RadioButton);
            Controls.Add(OneButtonOnTheMainWindow_RadioButton);
            Controls.Add(label1);
            Controls.Add(OutputData_Button);
            Controls.Add(LocaltPathEntry_TextBox);
            Controls.Add(LocalPath_Label);
            Controls.Add(CloseSettingsWindow_Button);
            Controls.Add(SettingsText_Label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SettingsText_Label;
        private Button CloseSettingsWindow_Button;
        private Label LocalPath_Label;
        private TextBox LocaltPathEntry_TextBox;
        private Button OutputData_Button;
        private Label label1;
        private RadioButton OneButtonOnTheMainWindow_RadioButton;
        private RadioButton TwoButtonOnTheMainWindow_RadioButton;
        private RadioButton ThreeButtonOnTheMainWindow_RadioButton;
        private Button CostumizeButtons_Button;
    }
}