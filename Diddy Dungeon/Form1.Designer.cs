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
            button1 = new Button();
            openFileButton = new Button();
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
            // button1
            // 
            button1.Font = new Font("Old English Text MT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 357);
            button1.Name = "button1";
            button1.Size = new Size(462, 75);
            button1.TabIndex = 3;
            button1.Text = "Select File To Bet 👅😈";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(211, 562);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(150, 66);
            openFileButton.TabIndex = 4;
            openFileButton.Text = "button2";
            openFileButton.UseVisualStyleBackColor = true;
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
            Controls.Add(openFileButton);
            Controls.Add(button1);
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
        private Button button1;
        private Button openFileButton;
        private RichTextBox fileDisplay;
        private OpenFileDialog openFileDialog1;
    }
}
