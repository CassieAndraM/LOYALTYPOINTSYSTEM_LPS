using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LPSApplayer;
using LPSDataLayer;
namespace LoyaltyPointsSystemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserDecisionTo = String.Empty;
            string TransferDecision = String.Empty;
            string account = String.Empty;

            do
            {
                Console.WriteLine("\t\tPlease select from below menu\n");
                Console.WriteLine("\t\t{0, 8}{1, -15}{2, 15}", "SR.NO", "COLD BREW", "Price");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 15}", "1", "Iced Americano", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 15}", "2", "Iced Latte", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 13}", "3", "Caramel Macchiato", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 15}", "4", "Spanish Latte", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 15}", "5", "Choco Mocha", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 11}", "6", "Sweetened Cold Brew", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 14}", "7", "Caramelark Latte", "85 php");
                Console.WriteLine("\t\t{0, -8}{1, -15}{2, 16}", "8", "Matcha Latte", "85 php\n");

                Console.Write("Enter the number you want to order: ");
                int UserSelectionFromMenu = Convert.ToInt32(Console.ReadLine());
                ApplayerLPS.Userselection(UserSelectionFromMenu);
                do
                {
                    Console.WriteLine("\nDo you still want to buy more ?");
                    UserDecisionTo = Console.ReadLine().ToUpper();
                    switch (UserDecisionTo)
                    {
                        case "YES":
                            continue;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine($"Your choice is {UserDecisionTo} is invalid");
                            break;
                    }

                }

                while (UserDecisionTo != "YES" && UserDecisionTo != "NO");
            }
            while (UserDecisionTo.ToUpper() != "NO");

            Console.WriteLine($"\nYour bill amount is {ApplayerLPS.TotalMilkShakeBill}");
            Console.WriteLine($"The points you get is {ApplayerLPS.TotalPoints}");
            Console.WriteLine();
            Console.WriteLine("Do you have an account to transfer your points?");
            account = Console.ReadLine().ToUpper();

            do
            {

                switch (account)
                {
                    case "YES":
                        Console.WriteLine("\nLOGIN YOUR ACCOUNT");
                        Console.WriteLine("Enter Account Name");
                        User.Verifying();
                        break;
                    case "NO":
                        Console.WriteLine("Now we create a new user");
                        Console.WriteLine("Enter Account Name");
                        User.creating();
                        Console.WriteLine("\nSuccessfully created your account");
                        continue;
                    default:
                        Console.WriteLine($"Your choice is {account} is invalid");
                        break;

                }
            } while (account == string.Empty);

            Console.WriteLine("Do you wish to transfer your points to your account?");
            TransferDecision = Console.ReadLine().ToUpper();
            switch (TransferDecision)
            {
                case "YES":
                    User.Transfer();
                    Console.WriteLine($"TotalPoints: {ApplayerLPS.TotalPoints}");
                    break;
                case "NO":
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }


        }

    }
}
