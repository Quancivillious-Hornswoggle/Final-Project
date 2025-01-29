namespace Diddy_Dungeon
{
    partial class Form1
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
            output1 = new RichTextBox();
            output2 = new RichTextBox();
            output3 = new RichTextBox();
            openFileButton = new Button();
            betButton = new Button();
            fileDisplay = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // output1
            // 
            output1.Location = new Point(55, 171);
            output1.Name = "output1";
            output1.Size = new Size(150, 144);
            output1.TabIndex = 0;
            output1.Text = "";
            // 
            // output2
            // 
            output2.Location = new Point(211, 171);
            output2.Name = "output2";
            output2.Size = new Size(150, 144);
            output2.TabIndex = 1;
            output2.Text = "";
            // 
            // output3
            // 
            output3.Location = new Point(367, 171);
            output3.Name = "output3";
            output3.Size = new Size(150, 144);
            output3.TabIndex = 2;
            output3.Text = "";
            // 
            // openFileButton
            // 
            openFileButton.Font = new Font("Old English Text MT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openFileButton.Location = new Point(55, 357);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(462, 75);
            openFileButton.TabIndex = 3;
            openFileButton.Text = "Select File To Bet 👅😈";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += OpenFileClick;
            // 
            // betButton
            // 
            betButton.Location = new Point(211, 562);
            betButton.Name = "betButton";
            betButton.Size = new Size(150, 66);
            betButton.TabIndex = 4;
            betButton.Text = "Bet";
            betButton.UseVisualStyleBackColor = true;
            betButton.Click += BetButtonClick;
            // 
            // fileDisplay
            // 
            fileDisplay.BorderStyle = BorderStyle.None;
            fileDisplay.DetectUrls = false;
            fileDisplay.Font = new Font("Segoe UI", 12F);
            fileDisplay.Location = new Point(55, 450);
            fileDisplay.Name = "fileDisplay";
            fileDisplay.ReadOnly = true;
            fileDisplay.Size = new Size(462, 106);
            fileDisplay.TabIndex = 5;
            fileDisplay.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 673);
            Controls.Add(fileDisplay);
            Controls.Add(betButton);
            Controls.Add(openFileButton);
            Controls.Add(output3);
            Controls.Add(output2);
            Controls.Add(output1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox output1;
        private RichTextBox output3;
        private RichTextBox output2;
        private Button openFileButton;
        private Button betButton;
        private RichTextBox fileDisplay;
        private OpenFileDialog openFileDialog1;
    }
}
