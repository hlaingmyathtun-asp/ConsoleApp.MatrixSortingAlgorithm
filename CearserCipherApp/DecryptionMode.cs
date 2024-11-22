using System;

namespace CeaserCipherApp
{
    sealed class DecryptionMode : CeaserCipher
    {
        private string cipherText;
        private int shiftKey;

        private char[] chars;

        private string decryptedChar = string.Empty;

        private int numberOfAlphabet = 0;

        private int finalizedChar = 0;


        public override char[] Chars
        {
            get { return chars; }
            set { chars = value; }
        }

        public string CipherText { get; set; }

        public int ShiftKey { get; set; }

        public DecryptionMode(string cipherText, int shiftKey)
        {

            this.cipherText = cipherText;
            this.shiftKey = shiftKey;

            this.Chars = base.chars;
        }

        /// <summary>
        /// This is abstract implementatoin method for Encryption.
        /// It cannot use for decryption mode.
        /// </summary>
        /// <param name="palinText"></param>
        /// <param name="shiftKey"></param>
        /// <returns></returns>

        public override string Encryption(string plainText, int shiftKey)
        {
            string encryptedText = "Sorry, This is decryption mode class. Please use encryption class";
            return $"\t\t\t\t\t{encryptedText}";
        }



        /// <summary>
        /// this is implementation method for decryption class.
        /// It cannot use for decrypion.
        /// </summary>
        /// <param name="cipherText">Receive the cipher text from user</param>
        /// <param name="shiftKey">Receive the no: of key for decryption</param>
        /// <returns></returns>

        public override string Decryption(string cipherText, int shiftKey)
        {
            try
            {
                for (int i = 0; i < cipherText.Length; i++)
                {
                    for (int k = 0; k < Chars.Length; k++)
                    {
                        char userChar = cipherText[i];
                        char charDataBase = Chars[k];
                        if (userChar == charDataBase)
                        {

                            numberOfAlphabet = k - shiftKey;
                            if (numberOfAlphabet < 0)
                            {
                                numberOfAlphabet = (-numberOfAlphabet);
                                numberOfAlphabet = Chars.Length - numberOfAlphabet;
                            }

                            finalizedChar = numberOfAlphabet % Chars.Length;

                            decryptedChar += Chars[finalizedChar];

                        }


                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (cipherText == null)
                {
                    Console.WriteLine("\t\t\t\t\tPlease enter the words for decryption");
                    Console.WriteLine();
                }
                else if (shiftKey >= 106)
                {
                    Console.WriteLine($"\t\t\t\t\t The shifting key, {shiftKey} cannot be over the 106");
                    Console.WriteLine();
                }
            }




            return decryptedChar;


        }
    }
}
