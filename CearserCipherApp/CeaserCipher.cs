﻿namespace CeaserCipherApp
{
    abstract class CeaserCipher
    {
        protected char[] chars = { 'A', 'B', 'C' ,'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i','j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '!', '@', '#', '$', '%', '^', '&',
                                        '*', '(', ')','-', '_', '+', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '\'', '\"', '<', '>', ',', '.', '?', '/', '~', '`', '1', '2', '3','4', '5', '6', '7', '8',
                                        '9', '0', ' '};
        public abstract char[] Chars { get; set; }


        public abstract string Encryption(string plainText, int shiftKey);
        public abstract string Decryption(string cipherText, int shiftKey);

    }
}
