using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPSApplayer;
namespace LPSDataLayer
{
    class TRansferpoints
    {
        public static string studentsBorrowedBooks = "TransferPoints.txt";
        public static void AppendFile(List<string> userInput, List<string> dateTime)
        {
            Queue<string> deferredLines = new Queue<string>();

            using (StreamWriter file = File.AppendText(studentsBorrowedBooks))
            {

                WriteDataInFile(file, userInput, dateTime);

            }
        }
        internal static void WriteDataInFile(StreamWriter file, List<string> userInput, List<string> dateTime)
        {

            foreach (var data in userInput)
            {
                file.Write(data);

                if (data.Length == 2)
                {
                    file.Write("");
                }
                else
                {
                    foreach (var data1 in dateTime)
                    {
                        file.Write($"\t\t{data1}\n");
                    }
                }

            }
        }
        public static List<string> BorrowedReadFile()
        {
            List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(studentsBorrowedBooks))
            {

                string line = sr.ReadLine();

                while (line != null)
                {
                    dataContent.Add(line);
                    line = sr.ReadLine();
                }
            }
            return dataContent;

        }
        public static void StudentsBorrowedin()
        {
            List<string> userName = ApplayerLPS.AccountName();
            AppendFile(userName, userName);
        }
    }
}