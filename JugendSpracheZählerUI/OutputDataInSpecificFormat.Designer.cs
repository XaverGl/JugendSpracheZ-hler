namespace JugendSpracheZählerUI
{
    partial class OutputDataInSpecificFormat
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
            CloseOutputDataWindow_Button = new Button();
            SpecificTime_RadioButton = new RadioButton();
            OnlyOneDay_RadioButton = new RadioButton();
            StartDay_TextBox = new TextBox();
            StartDate_Label = new Label();
            EndDateOfWeek_Label = new Label();
            EndDate_TextBox = new TextBox();
            GetFileWithData_Button = new Button();
            SuspendLayout();
            // 
            // CloseOutputDataWindow_Button
            // 
            CloseOutputDataWindow_Button.BackColor = Color.FromArgb(192, 0, 0);
            CloseOutputDataWindow_Button.FlatStyle = FlatStyle.Popup;
            CloseOutputDataWindow_Button.ForeColor = Color.Black;
            CloseOutputDataWindow_Button.Location = new Point(473, 12);
            CloseOutputDataWindow_Button.Name = "CloseOutputDataWindow_Button";
            CloseOutputDataWindow_Button.Size = new Size(30, 30);
            CloseOutputDataWindow_Button.TabIndex = 5;
            CloseOutputDataWindow_Button.Text = "X";
            CloseOutputDataWindow_Button.UseVisualStyleBackColor = false;
            CloseOutputDataWindow_Button.Click += CloseOutputDataWindow_Button_Click;
            // 
            // SpecificTime_RadioButton
            // 
            SpecificTime_RadioButton.AutoSize = true;
            SpecificTime_RadioButton.Checked = true;
            SpecificTime_RadioButton.ForeColor = Color.White;
            SpecificTime_RadioButton.Location = new Point(12, 12);
            SpecificTime_RadioButton.Name = "SpecificTime_RadioButton";
            SpecificTime_RadioButton.Size = new Size(130, 19);
            SpecificTime_RadioButton.TabIndex = 6;
            SpecificTime_RadioButton.TabStop = true;
            SpecificTime_RadioButton.Text = "SpecificTimeOutput";
            SpecificTime_RadioButton.UseVisualStyleBackColor = true;
            SpecificTime_RadioButton.CheckedChanged += SpecificTime_RadioButton_CheckedChanged;
            // 
            // OnlyOneDay_RadioButton
            // 
            OnlyOneDay_RadioButton.AutoSize = true;
            OnlyOneDay_RadioButton.ForeColor = Color.White;
            OnlyOneDay_RadioButton.Location = new Point(148, 12);
            OnlyOneDay_RadioButton.Name = "OnlyOneDay_RadioButton";
            OnlyOneDay_RadioButton.Size = new Size(130, 19);
            OnlyOneDay_RadioButton.TabIndex = 7;
            OnlyOneDay_RadioButton.Text = "OnlyOneDayOutput";
            OnlyOneDay_RadioButton.UseVisualStyleBackColor = true;
            // 
            // StartDay_TextBox
            // 
            StartDay_TextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartDay_TextBox.Location = new Point(127, 61);
            StartDay_TextBox.Name = "StartDay_TextBox";
            StartDay_TextBox.Size = new Size(151, 25);
            StartDay_TextBox.TabIndex = 8;
            // 
            // StartDate_Label
            // 
            StartDate_Label.AutoSize = true;
            StartDate_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartDate_Label.ForeColor = Color.White;
            StartDate_Label.Location = new Point(12, 63);
            StartDate_Label.Name = "StartDate_Label";
            StartDate_Label.Size = new Size(17, 21);
            StartDate_Label.TabIndex = 9;
            StartDate_Label.Text = "x";
            // 
            // EndDateOfWeek_Label
            // 
            EndDateOfWeek_Label.AutoSize = true;
            EndDateOfWeek_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EndDateOfWeek_Label.ForeColor = Color.White;
            EndDateOfWeek_Label.Location = new Point(12, 110);
            EndDateOfWeek_Label.Name = "EndDateOfWeek_Label";
            EndDateOfWeek_Label.Size = new Size(17, 21);
            EndDateOfWeek_Label.TabIndex = 10;
            EndDateOfWeek_Label.Text = "x";
            // 
            // EndDate_TextBox
            // 
            EndDate_TextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EndDate_TextBox.Location = new Point(127, 108);
            EndDate_TextBox.Name = "EndDate_TextBox";
            EndDate_TextBox.Size = new Size(151, 25);
            EndDate_TextBox.TabIndex = 11;
            // 
            // GetFileWithData_Button
            // 
            GetFileWithData_Button.Location = new Point(185, 179);
            GetFileWithData_Button.Name = "GetFileWithData_Button";
            GetFileWithData_Button.Size = new Size(109, 23);
            GetFileWithData_Button.TabIndex = 12;
            GetFileWithData_Button.Text = "GetFileWithData";
            GetFileWithData_Button.UseVisualStyleBackColor = true;
            // 
            // OutputDataInSpecificFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(515, 273);
            Controls.Add(GetFileWithData_Button);
            Controls.Add(EndDate_TextBox);
            Controls.Add(EndDateOfWeek_Label);
            Controls.Add(StartDate_Label);
            Controls.Add(StartDay_TextBox);
            Controls.Add(OnlyOneDay_RadioButton);
            Controls.Add(SpecificTime_RadioButton);
            Controls.Add(CloseOutputDataWindow_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OutputDataInSpecificFormat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OutputDataInSpecificFormat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseOutputDataWindow_Button;
        private RadioButton SpecificTime_RadioButton;
        private RadioButton OnlyOneDay_RadioButton;
        private TextBox StartDay_TextBox;
        private Label StartDate_Label;
        private Label EndDateOfWeek_Label;
        private TextBox EndDate_TextBox;
        private Button GetFileWithData_Button;
    }
}