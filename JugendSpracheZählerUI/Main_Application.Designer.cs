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
            CountHigher_Button.Location = new Point(115, 211);
            CountHigher_Button.Name = "CountHigher_Button";
            CountHigher_Button.Size = new Size(80, 35);
            CountHigher_Button.TabIndex = 0;
            CountHigher_Button.Text = "x";
            CountHigher_Button.UseVisualStyleBackColor = true;
            // 
            // CountLower_Button
            // 
            CountLower_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountLower_Button.Location = new Point(350, 211);
            CountLower_Button.Name = "CountLower_Button";
            CountLower_Button.Size = new Size(80, 35);
            CountLower_Button.TabIndex = 1;
            CountLower_Button.Text = "x";
            CountLower_Button.UseVisualStyleBackColor = true;
            // 
            // Counter_Label
            // 
            Counter_Label.AutoSize = true;
            Counter_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Counter_Label.Location = new Point(115, 94);
            Counter_Label.Name = "Counter_Label";
            Counter_Label.Size = new Size(17, 21);
            Counter_Label.TabIndex = 2;
            Counter_Label.Text = "x";
            // 
            // CloseApplication_Button
            // 
            CloseApplication_Button.BackColor = Color.FromArgb(192, 0, 0);
            CloseApplication_Button.FlatStyle = FlatStyle.Popup;
            CloseApplication_Button.ForeColor = Color.Black;
            CloseApplication_Button.Location = new Point(489, 12);
            CloseApplication_Button.Name = "CloseApplication_Button";
            CloseApplication_Button.Size = new Size(30, 30);
            CloseApplication_Button.TabIndex = 3;
            CloseApplication_Button.Text = "X";
            CloseApplication_Button.UseVisualStyleBackColor = false;
            CloseApplication_Button.Click += CloseApplication_Button_Click;
            // 
            // OpenSettings_Button
            // 
            OpenSettings_Button.Location = new Point(12, 12);
            OpenSettings_Button.Name = "OpenSettings_Button";
            OpenSettings_Button.Size = new Size(75, 23);
            OpenSettings_Button.TabIndex = 4;
            OpenSettings_Button.Text = "x";
            OpenSettings_Button.UseVisualStyleBackColor = true;
            OpenSettings_Button.Click += OpenSettings_Button_Click;
            // 
            // CounterNumber_TextBox
            // 
            CounterNumber_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CounterNumber_TextBox.Location = new Point(218, 91);
            CounterNumber_TextBox.Name = "CounterNumber_TextBox";
            CounterNumber_TextBox.ReadOnly = true;
            CounterNumber_TextBox.Size = new Size(100, 29);
            CounterNumber_TextBox.TabIndex = 5;
            // 
            // SaveAndLoadIntoAFile_Button
            // 
            SaveAndLoadIntoAFile_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveAndLoadIntoAFile_Button.Location = new Point(175, 274);
            SaveAndLoadIntoAFile_Button.Name = "SaveAndLoadIntoAFile_Button";
            SaveAndLoadIntoAFile_Button.Size = new Size(197, 26);
            SaveAndLoadIntoAFile_Button.TabIndex = 6;
            SaveAndLoadIntoAFile_Button.Text = "x";
            SaveAndLoadIntoAFile_Button.UseVisualStyleBackColor = true;
            // 
            // Main_Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(531, 312);
            Controls.Add(SaveAndLoadIntoAFile_Button);
            Controls.Add(CounterNumber_TextBox);
            Controls.Add(OpenSettings_Button);
            Controls.Add(CloseApplication_Button);
            Controls.Add(Counter_Label);
            Controls.Add(CountLower_Button);
            Controls.Add(CountHigher_Button);
            FormBorderStyle = FormBorderStyle.None;
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
