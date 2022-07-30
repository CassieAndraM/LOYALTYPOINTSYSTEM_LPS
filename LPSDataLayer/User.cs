using System;
using System.Collections.Generic;
using System.IO;
using LPSApplayer;

namespace LPSDataLayer
{
    public class User
    {
        public static string CreateUser = "CreateUser.txt";
        public static void AppendFile(List<string> userInput)
        {
            Queue<string> deferredLines = new Queue<string>();

            using (StreamWriter file = File.AppendText(CreateUser))
            {

                WriteDataInFile(file, userInput);

            }
        }
        internal static void WriteDataInFile(StreamWriter file, List<string> userInput)
        {

            foreach (var data in userInput)
            {
                file.Write(data);

            }
        }
        public static void creating()
        {
            List<string> userName = ApplayerLPS.AccountName();
            AppendFile(userName);
        }
        public static void Verifying()
        {
            List<string> datalist = new List<string>();
            string verificaation;
            Console.Write("\nAccount Name: ");
            verificaation = Console.ReadLine();
            var lines = File.ReadAllLines(CreateUser);
            string result = null;
            foreach (var line in lines)
            {
                if (line.Contains(verificaation))
                {
                    result = line;
                    break;
                }
            }

            if (result == verificaation)
            {
                Console.WriteLine("\nLogin Successful!\n", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nYou have entered the incorrect information. Login Failed.", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("Please login again.\n");
                Console.ResetColor();
            }
        }
        public static void Transfer()
        {
            List<string> datalist = new List<string>();
            string verificaation;
            Console.Write("\nAccount Name: ");
            verificaation = Console.ReadLine();
            var lines = File.ReadAllLines(CreateUser);
            string result = null;
            foreach (var line in lines)
            {
                if (line.Contains(verificaation))
                {
                    result = line;
                    break;
                }
            }
            if (result == verificaation)
            {
                Console.WriteLine("\nTransfer Successfull!!!", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
                Console.WriteLine($"Student Number: {verificaation}");
            }
            else
            {
                Console.WriteLine("\nYou have entered the incorrect information. Login Failed.", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("Please login again.\n");
                Console.ResetColor();
            }
        }
    }
}
