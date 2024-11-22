using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CeaserCipherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        prompt:
            try
            {
            askback: Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t*****WELCOME TO ZENTEK ASIA CEASER CIPHER APP*****");

                Console.WriteLine("\t\t\t\t\tChoose the below mode: 1 (or) 2 (or) 3 ");
                Console.Write("\t\t\t\t\t1. Encryption mode\n");
                Console.Write("\t\t\t\t\t2. Decryption mode\n");
                Console.Write("\t\t\t\t\t3. Exit \n");

                Console.Write("\t\t\t\t Mode => ");
                Console.ResetColor();
                int.TryParse(Console.ReadLine(), out int mode);


                Console.ForegroundColor = ConsoleColor.Green;
                switch (mode)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\tWelcome To Encryption Mode");
                        ModeOne();
                        break;
                    case 2:

                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\tWelcome To Decryption Mode");
                        ModeTwo();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\tGoodbye, Have A Nice Day!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("\t\tSorry, please read the menu: ");
                        goto askback;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
            askUser: Console.Write("Would you like to try it back       : yes or no  => ");
                Console.ForegroundColor = ConsoleColor.White;


                string userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto askback;
                }

                else if (userAnswer == "no")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GoodBye, Thank you for using ZenTek Asia application");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t**** Please type only yes or no ****");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto askUser;
                }

            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, Something wrong => please try back");
                goto prompt;

            }


            Console.ResetColor();

        }

        public static void ModeOne()
        {

            Console.Write("Please enter the message that you want to encrypt : ");
            Console.ForegroundColor = ConsoleColor.White;
            string encryptedMessage = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\t\tPlease enter the shifting key     : ");
            Console.ForegroundColor = ConsoleColor.White;

            int.TryParse(Console.ReadLine(), out int shiftKey);

            Console.ForegroundColor = ConsoleColor.Green;

            EncryptionMode encryptionMode = new EncryptionMode(encryptedMessage, shiftKey);

            encryptionMode.PlainText = encryptedMessage;
            encryptionMode.ShiftKey = shiftKey;

            string encryptionResult = encryptionMode.Encryption(encryptionMode.PlainText, encryptionMode.ShiftKey);

            Console.WriteLine("\t\t\tEncrypted Message         : {0} ", encryptionResult);
            Console.WriteLine();

        fileOption: Console.WriteLine("Would you like to create the encrypted file       : yes (or) no ");

            Console.Write("\t\t\t\t\t\t => ");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Green;

            if (answer == "yes")
            {
                string directoryLocation = "C:\\EncryptedFolder\\";



                Directory.CreateDirectory(directoryLocation);

                string encryptedFileName = "C:\\EncryptedFolder\\" + $"{encryptionResult}.txt";

                StreamWriter fileWriter = new StreamWriter(encryptedFileName);

                fileWriter.Write(encryptionResult);

                
                Console.Write("File was successfully Created in ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{encryptedFileName}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                fileWriter.Close();
            }

            else if (answer == "no")
            {
                Console.WriteLine("The file didn't store in the folder");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t****Please choose yes or no only****");
                Console.ForegroundColor = ConsoleColor.Green;
                goto fileOption;
            }



        }

        public static void ModeTwo()
        {
        chooseBack: string directoryLocation = "C:\\DecryptedFile";
            string encryptedFileName = string.Empty;
            int shiftKey;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please choose the type : file or text  : ");
            Console.ForegroundColor = ConsoleColor.White;

            string answer = Console.ReadLine().ToLower();

            if (answer == "file")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("\tPlease enter the file location : ");
                Console.ForegroundColor = ConsoleColor.White;

                string userFileLocation = Console.ReadLine();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tPlease enter the shifting key  : ");
                Console.ForegroundColor = ConsoleColor.White;



                int.TryParse(Console.ReadLine(), out shiftKey);
                Console.ForegroundColor = ConsoleColor.Green;

                StreamReader fileReader = new StreamReader(userFileLocation);

                string fileData = fileReader.ReadToEnd();

                DecryptionMode decryptionMode = new DecryptionMode(fileData, shiftKey);
                decryptionMode.CipherText = fileData;

                decryptionMode.ShiftKey = shiftKey;

                string descryptionResult = decryptionMode.Decryption(decryptionMode.CipherText, decryptionMode.ShiftKey);


                Console.WriteLine("\t\tDecrypted Message      : {0} ", descryptionResult);

                Console.WriteLine("Would you like to save decrypted file in the folder ? ");
                Console.Write("\t\t\tyes or no     =>  ");
                Console.ForegroundColor = ConsoleColor.White;
                string saveFile = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Green;


                if (saveFile == "yes")
                {

                    Directory.CreateDirectory(directoryLocation);


                    string decryptedFileLocaton = "C:\\DecryptedFile\\" + $"{descryptionResult}.txt";

                    StreamWriter streamWriter = new StreamWriter(decryptedFileLocaton);

                    streamWriter.Write(descryptionResult);

                    streamWriter.Close();
                    Console.Write("The file was saved in this location    : ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{directoryLocation}");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.WriteLine("The decrypted file wasn't saved");
                }


            }

            else if (answer == "text")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("\tEnter enter the text to decrypt: ");
                Console.ForegroundColor = ConsoleColor.White;

                string decryptedMessage = Console.ReadLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("\tPlease enter the shifting key  : ");
                Console.ForegroundColor = ConsoleColor.White;

                int.TryParse(Console.ReadLine(), out shiftKey);

                Console.ForegroundColor = ConsoleColor.Green;

                DecryptionMode decryptionMode = new DecryptionMode(decryptedMessage, shiftKey);

                decryptionMode.CipherText = decryptedMessage;

                decryptionMode.ShiftKey = shiftKey;

                string descryptionResult = decryptionMode.Decryption(decryptionMode.CipherText, decryptionMode.ShiftKey);


                Console.WriteLine("\t\tDecrypted Message      : {0} ", descryptionResult);


                Console.WriteLine();

                Console.WriteLine("Would you like to save file in the folder ? ");
                Console.Write("\t\t\tyes or no     =>  ");
                Console.ForegroundColor = ConsoleColor.White;
                string saveFile = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Green;


                if (saveFile == "yes")
                {

                    Directory.CreateDirectory(directoryLocation);


                    string decryptedFileLocaton = "C:\\DecryptedFile\\" + $"{descryptionResult}.txt";

                    StreamWriter streamWriter = new StreamWriter(decryptedFileLocaton);

                    streamWriter.Write(descryptionResult);

                    streamWriter.Close();
                    Console.Write("The file was saved in this location    : ");
                    Console.WriteLine($"{directoryLocation}");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.WriteLine("The decrypted file wasn't saved");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t****Please choose back (file or text)****");
                goto chooseBack;
            }



            Console.ResetColor();


        }



    }
}
