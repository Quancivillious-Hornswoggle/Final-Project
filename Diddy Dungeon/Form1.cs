using System.Runtime.CompilerServices;

namespace Diddy_Dungeon
{
    public partial class Form1 : Form
    {
        public static RichTextBox slotOutput1;
        public static RichTextBox slotOutput2;
        public static RichTextBox slotOutput3;
        public static RichTextBox betFileDisplay;
        public static OpenFileDialog openFileDialog;
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
            openFileDialog = openFileDialog1;

            FileHandler.InitializeEncryption();

            // Initialize the game
            GameLogic gameLogic = new GameLogic();
            gameLogic.Run();
        }

        private void OpenFileClick(object sender, EventArgs e) // Button to open file and set it to bet
        {
            FileHandler.SetFileToBet();
            bool status = FileHandler.EncryptFile(betFilePath);
        }

        private void BetButtonClick(object sender, EventArgs e)
        {

        }
    }
}
