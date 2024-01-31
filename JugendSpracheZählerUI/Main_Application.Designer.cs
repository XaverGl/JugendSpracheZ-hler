namespace JugendSpracheZählerUI
{
    partial class Main_Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CountHigher_Button = new Button();
            CountLower_Button = new Button();
            Counter_Label = new Label();
            CloseApplication_Button = new Button();
            OpenSettings_Button = new Button();
            CounterNumber_TextBox = new TextBox();
            SaveAndLoadIntoAFile_Button = new Button();
            SuspendLayout();
            // 
            // CountHigher_Button
            // 
            CountHigher_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountHigher_Button.Location = new Point(131, 281);
            CountHigher_Button.Margin = new Padding(3, 4, 3, 4);
            CountHigher_Button.Name = "CountHigher_Button";
            CountHigher_Button.Size = new Size(91, 47);
            CountHigher_Button.TabIndex = 0;
            CountHigher_Button.Text = "x";
            CountHigher_Button.UseVisualStyleBackColor = true;
            CountHigher_Button.Click += CountHigher_Button_Click;
            // 
            // CountLower_Button
            // 
            CountLower_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountLower_Button.Location = new Point(400, 281);
            CountLower_Button.Margin = new Padding(3, 4, 3, 4);
            CountLower_Button.Name = "CountLower_Button";
            CountLower_Button.Size = new Size(91, 47);
            CountLower_Button.TabIndex = 1;
            CountLower_Button.Text = "x";
            CountLower_Button.UseVisualStyleBackColor = true;
            CountLower_Button.Click += CountLower_Button_Click;
            // 
            // Counter_Label
            // 
            Counter_Label.AutoSize = true;
            Counter_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Counter_Label.Location = new Point(131, 125);
            Counter_Label.Name = "Counter_Label";
            Counter_Label.Size = new Size(21, 28);
            Counter_Label.TabIndex = 2;
            Counter_Label.Text = "x";
            // 
            // CloseApplication_Button
            // 
            CloseApplication_Button.BackColor = Color.FromArgb(192, 0, 0);
            CloseApplication_Button.FlatStyle = FlatStyle.Popup;
            CloseApplication_Button.ForeColor = Color.Black;
            CloseApplication_Button.Location = new Point(559, 16);
            CloseApplication_Button.Margin = new Padding(3, 4, 3, 4);
            CloseApplication_Button.Name = "CloseApplication_Button";
            CloseApplication_Button.Size = new Size(34, 40);
            CloseApplication_Button.TabIndex = 3;
            CloseApplication_Button.Text = "X";
            CloseApplication_Button.UseVisualStyleBackColor = false;
            CloseApplication_Button.Click += CloseApplication_Button_Click;
            // 
            // OpenSettings_Button
            // 
            OpenSettings_Button.Location = new Point(14, 16);
            OpenSettings_Button.Margin = new Padding(3, 4, 3, 4);
            OpenSettings_Button.Name = "OpenSettings_Button";
            OpenSettings_Button.Size = new Size(86, 31);
            OpenSettings_Button.TabIndex = 4;
            OpenSettings_Button.Text = "x";
            OpenSettings_Button.UseVisualStyleBackColor = true;
            OpenSettings_Button.Click += OpenSettings_Button_Click;
            // 
            // CounterNumber_TextBox
            // 
            CounterNumber_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CounterNumber_TextBox.Location = new Point(249, 121);
            CounterNumber_TextBox.Margin = new Padding(3, 4, 3, 4);
            CounterNumber_TextBox.Name = "CounterNumber_TextBox";
            CounterNumber_TextBox.ReadOnly = true;
            CounterNumber_TextBox.Size = new Size(114, 34);
            CounterNumber_TextBox.TabIndex = 5;
            // 
            // SaveAndLoadIntoAFile_Button
            // 
            SaveAndLoadIntoAFile_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveAndLoadIntoAFile_Button.Location = new Point(200, 365);
            SaveAndLoadIntoAFile_Button.Margin = new Padding(3, 4, 3, 4);
            SaveAndLoadIntoAFile_Button.Name = "SaveAndLoadIntoAFile_Button";
            SaveAndLoadIntoAFile_Button.Size = new Size(225, 35);
            SaveAndLoadIntoAFile_Button.TabIndex = 6;
            SaveAndLoadIntoAFile_Button.Text = "x";
            SaveAndLoadIntoAFile_Button.UseVisualStyleBackColor = true;
            SaveAndLoadIntoAFile_Button.Click += SaveAndLoadIntoAFile_Button_Click;
            // 
            // Main_Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(607, 416);
            Controls.Add(SaveAndLoadIntoAFile_Button);
            Controls.Add(CounterNumber_TextBox);
            Controls.Add(OpenSettings_Button);
            Controls.Add(CloseApplication_Button);
            Controls.Add(Counter_Label);
            Controls.Add(CountLower_Button);
            Controls.Add(CountHigher_Button);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main_Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAINWINDOW";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CountHigher_Button;
        private Button CountLower_Button;
        private Label Counter_Label;
        private Button CloseApplication_Button;
        private Button OpenSettings_Button;
        private TextBox CounterNumber_TextBox;
        private Button SaveAndLoadIntoAFile_Button;
    }
}
