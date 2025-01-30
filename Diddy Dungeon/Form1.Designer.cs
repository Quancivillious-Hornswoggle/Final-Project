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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            output1 = new RichTextBox();
            openFileButton = new Button();
            betButton = new Button();
            fileDisplay = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            output3 = new RichTextBox();
            output2 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // output1
            // 
            output1.BackColor = Color.Black;
            output1.BorderStyle = BorderStyle.None;
            output1.DetectUrls = false;
            output1.Enabled = false;
            output1.Font = new Font("Segoe UI", 50F);
            output1.ForeColor = Color.Blue;
            output1.Location = new Point(55, 171);
            output1.Multiline = false;
            output1.Name = "output1";
            output1.ReadOnly = true;
            output1.ScrollBars = RichTextBoxScrollBars.None;
            output1.Size = new Size(150, 144);
            output1.TabIndex = 0;
            output1.Text = " 👽";
            // 
            // openFileButton
            // 
            openFileButton.BackColor = Color.Gray;
            openFileButton.Font = new Font("Old English Text MT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openFileButton.ForeColor = Color.DarkRed;
            openFileButton.Location = new Point(55, 357);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(462, 75);
            openFileButton.TabIndex = 3;
            openFileButton.Text = "Select File To Bet 👅😈";
            openFileButton.UseVisualStyleBackColor = false;
            openFileButton.Click += OpenFileClick;
            // 
            // betButton
            // 
            betButton.BackColor = Color.Gray;
            betButton.Enabled = false;
            betButton.Location = new Point(211, 562);
            betButton.Name = "betButton";
            betButton.Size = new Size(150, 66);
            betButton.TabIndex = 4;
            betButton.Text = "BET";
            betButton.UseVisualStyleBackColor = false;
            betButton.Click += BetButtonClick;
            // 
            // fileDisplay
            // 
            fileDisplay.BackColor = Color.Black;
            fileDisplay.BorderStyle = BorderStyle.None;
            fileDisplay.DetectUrls = false;
            fileDisplay.Enabled = false;
            fileDisplay.Font = new Font("Segoe UI", 12F);
            fileDisplay.ForeColor = Color.Blue;
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
            // output3
            // 
            output3.BackColor = Color.Black;
            output3.BorderStyle = BorderStyle.None;
            output3.DetectUrls = false;
            output3.Enabled = false;
            output3.Font = new Font("Segoe UI", 50F);
            output3.ForeColor = Color.Blue;
            output3.Location = new Point(367, 171);
            output3.Multiline = false;
            output3.Name = "output3";
            output3.ReadOnly = true;
            output3.ScrollBars = RichTextBoxScrollBars.None;
            output3.Size = new Size(145, 144);
            output3.TabIndex = 6;
            output3.Text = " 👽";
            // 
            // output2
            // 
            output2.BackColor = Color.Black;
            output2.BorderStyle = BorderStyle.None;
            output2.DetectUrls = false;
            output2.Enabled = false;
            output2.Font = new Font("Segoe UI", 50F);
            output2.ForeColor = Color.Blue;
            output2.Location = new Point(211, 171);
            output2.Multiline = false;
            output2.Name = "output2";
            output2.ReadOnly = true;
            output2.ScrollBars = RichTextBoxScrollBars.None;
            output2.Size = new Size(150, 144);
            output2.TabIndex = 7;
            output2.Text = " 👽";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(55, 53);
            label1.Name = "label1";
            label1.Size = new Size(457, 46);
            label1.TabIndex = 8;
            label1.Text = "DIDDY'S BETTING DUNGEON";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(567, 673);
            Controls.Add(label1);
            Controls.Add(output2);
            Controls.Add(output3);
            Controls.Add(fileDisplay);
            Controls.Add(betButton);
            Controls.Add(openFileButton);
            Controls.Add(output1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Diddy Slots";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox output1;
        private Button openFileButton;
        private Button betButton;
        private RichTextBox fileDisplay;
        private OpenFileDialog openFileDialog1;
        private RichTextBox output3;
        private RichTextBox output2;
        private Label label1;
    }
}
