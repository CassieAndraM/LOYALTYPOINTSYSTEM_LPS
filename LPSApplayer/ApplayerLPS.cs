using System;
using System.Collections.Generic;

namespace LPSApplayer
{
    public class ApplayerLPS
    {
        public static int TotalMilkShakeBill = 0;
        public static double TotalPoints = 0.00;
        public static void Userselection(int userSelectionFromMenu)
        {
            switch (userSelectionFromMenu)
            {
                case 1:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.10;
                    break;
                case 2:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.20;
                    break;
                case 3:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.30;
                    break;
                case 4:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.40;
                    break;
                case 5:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.50;
                    break;
                case 6:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.60;
                    break;
                case 7:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.70;
                    break;
                case 8:
                    TotalMilkShakeBill += 85;
                    TotalPoints += 0.80;
                    break;
                default:
                    Console.WriteLine($"Your Choice {userSelectionFromMenu} is invalid");
                    break;
            }
        }
        public static List<string> AccountName()
        {
            List<string> dataList = new List<string>();
            string userName;
            do
            {

                Console.Write("\nAccount Name: ");
                userName = Console.ReadLine();

                if (userName.Length == 15 && userName.StartsWith("20") && userName.EndsWith("BN-0"))
                {
                    dataList.Add($"\n{userName}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");

                }
                Console.ReadLine();


            } while (userName.Length != 0);

            return dataList;
        }
    }
}