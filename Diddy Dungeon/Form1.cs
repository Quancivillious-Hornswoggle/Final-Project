using System.Runtime.CompilerServices;

namespace Diddy_Dungeon
{
    //This is a comment to see if my push works
    public partial class Form1 : Form
    {
        public static RichTextBox slotOutput1;
        public static RichTextBox slotOutput2;
        public static RichTextBox slotOutput3;
        public static RichTextBox betFileDisplay;
        public static OpenFileDialog openFileDialog;
        public static Button fileBetButton;
        public static string betFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization
            slotOutput1 = output1;
            slotOutput2 = output2;
            slotOutput3 = output3;
            betFileDisplay = fileDisplay;
            openFileDialog = openFileDialog1;
            fileBetButton = openFileButton;

            FileHandler.InitializeEncryption();
        }

        private void OpenFileClick(object sender, EventArgs e) // Button to open file and set it to bet
        {
            // Set file
            FileHandler.SetFileToBet();

            betButton.Enabled = true;
        }

        private async void BetButtonClick(object sender, EventArgs e)
        {
            openFileButton.Enabled = false;
            betButton.Enabled = false;
            // Add file to memory

            Cursor = Cursors.WaitCursor;
            FileHandler.AddFileToMemory(betFilePath);
            Cursor = Cursors.Default;

            // Encrypt the file only after actively betting it
            FileHandler.EncryptFile(betFilePath);

            // Run game logic
            GameLogic game = new GameLogic();
            await game.Run();
        }
    }
}
