using System;

namespace CeaserCipherApp
{
    sealed class EncryptionMode : CeaserCipher
    {
        private string plainText;
        private int shiftKey;

        private char[] chars;

        private string encryptedChar = string.Empty;

        private int numberOfAlphabet = 0;

        private int finalizedChar = 0;


        public override char[] Chars
        {
            get { return chars; }
            set { chars = value; }
        }

        public string PlainText { get; set; }

        public int ShiftKey { get; set; }

        public EncryptionMode(string plainText, int shiftKey)
        {

            this.plainText = plainText;
            this.shiftKey = shiftKey;

            this.Chars = base.chars;
        }

        /// <summary>
        /// This is implementatoin method for Encryption class
        /// </summary>
        /// <param name="plainText">Receive the text from user</param>
        /// <param name="shiftKey">Receive the key of the user for encryption</param>
        /// <returns></returns>

        public override string Encryption(string plainText, int shiftKey)
        {
            try
            {



                for (int i = 0; i < plainText.Length; i++)
                {
                    for (int k = 0; k < Chars.Length; k++)
                    {
                        char userChar = plainText[i];
                        char charDataBase = Chars[k];
                        if (userChar == charDataBase)
                        {

                            numberOfAlphabet = k + shiftKey;


                            finalizedChar = numberOfAlphabet % Chars.Length;

                            encryptedChar += Chars[finalizedChar];

                        }


                    }
                }





            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (plainText == null)
                {
                    Console.WriteLine("\t\t\t\t\tPlease enter the words for encryption");
                    Console.WriteLine();
                }

                else if (shiftKey >= 106)
                {
                    Console.WriteLine($"\t\t\t\t\t The shifting key, {shiftKey} cannot be over the 106");
                    Console.WriteLine();
                }

            }




            return encryptedChar;
        }

        /// <summary>
        /// this is abstract method implementation for Encryption.
        /// It cannot use for encryption mode.
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="shiftKey"></param>
        /// <returns></returns>

        public override string Decryption(string cipherText, int shiftKey)
        {
            string decryptedText = "Sorry, This is encryption mode class. Please use decryption class";
            return $"\t\t\t\t\t{decryptedText}";
        }

    }
}
