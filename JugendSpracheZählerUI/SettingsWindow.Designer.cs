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
            SuspendLayout();
            // 
            // SettingsText_Label
            // 
            SettingsText_Label.AutoSize = true;
            SettingsText_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            OutputData_Button.Location = new Point(149, 118);
            OutputData_Button.Name = "OutputData_Button";
            OutputData_Button.Size = new Size(100, 23);
            OutputData_Button.TabIndex = 7;
            OutputData_Button.Text = "Output Data";
            OutputData_Button.UseVisualStyleBackColor = true;
            OutputData_Button.Click += OutputData_Button_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(515, 273);
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
    }
}