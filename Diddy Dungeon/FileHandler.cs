using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diddy_Dungeon
{
    internal class FileHandler
    {
        private static List<string[]> filesInMemory = new List<string[]>(); 

        private static byte[] key;
        private static byte[] iv;
        public static bool SetFileToBet()
        {
            try
            {
                Form1.openFileDialog.Title = "Select File To Bet";
                Form1.openFileDialog.FileName = "Select A File";
                Form1.openFileDialog.Multiselect = false;
                Form1.openFileDialog.ShowDialog();
                Form1.betFilePath = Form1.openFileDialog.FileName;
                Form1.betFileDisplay.Text = $"File being bet:\n{Form1.betFilePath}";
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool InitializeEncryption()
        {
            try
            {
                using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                {
                    key = aes.Key;
                    iv = aes.IV;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool EncryptFile(string filePath)
        {
            try
            {
                byte[] fileContent = File.ReadAllBytes(filePath);
                byte[] encryptedContent;

                using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    using (MemoryStream ms = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(fileContent, 0, fileContent.Length);
                        cs.FlushFinalBlock();
                        encryptedContent = ms.ToArray();
                    }
                }
                File.WriteAllBytes(filePath, encryptedContent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DecryptFile(string filePath)
        {
            try
            {
                byte[] encryptedContent = File.ReadAllBytes(filePath);
                byte[] decryptedContent;

                using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    using (MemoryStream ms = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedContent, 0, encryptedContent.Length);
                        cs.FlushFinalBlock();
                        decryptedContent = ms.ToArray();
                    }
                }
                File.WriteAllBytes(filePath, decryptedContent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AddFileToMemory(string filePath)
        {
            try
            {
                string[] fileInfo = new string[2];
                fileInfo[0] = fileInfo[0];
                fileInfo[1] = File.ReadAllBytes(filePath).ToString();
                filesInMemory.Add(fileInfo);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ReturnAllFilesFromMem()
        {
            try
            {
                foreach (string[] item in filesInMemory)
                {
                    byte[] filebytes = item[1];
                    File
                }

                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
