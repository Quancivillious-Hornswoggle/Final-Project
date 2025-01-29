using System.Runtime.CompilerServices;

namespace Diddy_Dungeon
{
    public partial class Form1 : Form
    {
        public static RichTextBox slotOutput1;
        public static RichTextBox slotOutput2;
        public static RichTextBox slotOutput3;
        public static RichTextBox betFileDisplay;
        public static string betFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the slot output variables
            slotOutput1 = output1;
            slotOutput2 = output2;
            slotOutput3 = output3;
            betFileDisplay = fileDisplay;

            // Initialize the game
            GameLogic gameLogic = new GameLogic();
            gameLogic.run();
        }

        private void button1_Click(object sender, EventArgs e) // Button to open file and set it to bet
        {
            openFileDialog1.Title = "Select File To Bet";
            openFileDialog1.FileName = "Select A File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            betFilePath = openFileDialog1.FileName;
            betFileDisplay.Text = $"File being bet:\n{betFilePath}";
        }
    }
}
