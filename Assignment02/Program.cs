/*
* Student ID : 1690701485
* Name       : Assignment02
* Section    : 129B
* No.        : 21
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SilverSmeltRate = 0.4500;
            var SilverBreakdownRate = 0.6000;

            var MaxBatchAmount = 500;
            var MinBatchAmount = 0;

            var ErrorMenuCheck = string.Empty;
            var ErrorAmountCheck = string.Empty;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║           THE FORGE GAME           ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("Choose an option:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  [S] - Smelt (Ore --> Ingot)");
            Console.WriteLine("  [B] - Breakdown (Ingot --> Ore)");
            Console.ResetColor();
            Console.Write("Your choice: ");

            ///Menu Input
            bool Choice = char.TryParse(Console.ReadLine(), out char userChoice);
            if (userChoice == 'S' || userChoice == 's')
            {
                Console.WriteLine("You chose: Smelt (Ore --> Ingot)");
            }
            else if (userChoice == 'B' || userChoice == 'b')
            {
                Console.WriteLine("You chose: Breakdown (Ingot --> Ore)");
            }
            else
            {
                ErrorMenuCheck = "Error Menu";
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter amount (1-500): ");
            Console.ResetColor();
            bool AmountInput = double.TryParse(Console.ReadLine(), out double Amount);

             if(AmountInput && Amount > MaxBatchAmount || AmountInput && Amount <= MinBatchAmount)
            {
                ErrorAmountCheck = "Error Amount";
            }
             else if(!AmountInput)
                {
                ErrorAmountCheck = "Error Amount";
                }

            ///Smelt or Breakdown Calculation
            if (userChoice == 'S' && ErrorMenuCheck == string.Empty && ErrorAmountCheck == string.Empty || userChoice == 's' && ErrorMenuCheck == string.Empty && ErrorAmountCheck == string.Empty)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║               RESULT               ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.ResetColor();
                double SilverSmelted = Amount * SilverSmeltRate;
                Console.WriteLine($"{Amount:F2} Silver Ore = {SilverSmelted:F2} Silver Ingot");
            }
            else if (userChoice == 'B' && ErrorMenuCheck == string.Empty && ErrorAmountCheck == string.Empty || userChoice == 'b' && ErrorMenuCheck == string.Empty && ErrorAmountCheck == string.Empty)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║               RESULT               ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.ResetColor();
                double SilverBrokenDown = Amount / SilverBreakdownRate;
                Console.WriteLine($"{Amount:F2} Silver Ingot = {SilverBrokenDown:F2} Silver Ore");
            }

            //Error Checking
            else if (ErrorMenuCheck != string.Empty || ErrorAmountCheck != string.Empty)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║               ERROR                ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.ResetColor();

                if (ErrorMenuCheck != string.Empty && ErrorAmountCheck == string.Empty)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ErrorMenuCheck}");
                    Console.ResetColor();
                }
                else if (ErrorMenuCheck == string.Empty && ErrorAmountCheck != string.Empty)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ErrorAmountCheck}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ErrorMenuCheck} and {ErrorAmountCheck}");
                    Console.ResetColor();
                }
            }
        }
    }
}