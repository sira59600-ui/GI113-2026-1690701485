namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SilverSmeltRate = 0.2500;
            var SilverBreakdownRate = 0.3000;

            var MaxBatchAmount = 500;
            var MinBatchAmount = 0;

            var ErrorMenuCheck = string.Empty;
            var ErrorAmountCheck = string.Empty;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║         🔥 The Forge eiei 🔥       ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose an option:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  [S] - Smelt (Ore → Ingot)");
            Console.WriteLine("  [B] - Breakdown (Ingot → Ore)");
            Console.ResetColor();
            Console.Write("Your choice: ");
            Console.ForegroundColor = ConsoleColor.White;

            ///Menu Input
            bool Choice = char.TryParse(Console.ReadLine(), out char userChoice);
            Console.ResetColor();
            Console.WriteLine();
            if (userChoice == 'S' || userChoice == 's')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✓ You chose: SMELT (Ore → Ingot)");
                Console.ResetColor();
            }
            else if (userChoice == 'B' || userChoice == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("✓ You chose: BREAKDOWN (Ingot → Ore)");
                Console.ResetColor();
            }
            else
            {
                ErrorMenuCheck = "Error Menu";
            }

            ///Amout Input
            Console.Write("Choose amount: ");
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
                double SilverSmelted = Amount * SilverSmeltRate;
                Console.WriteLine($"{Amount} Silver Ore = Silver Ingot: {SilverSmelted:F2}");//Ore to Ingot
            }
            else if (userChoice == 'B' && ErrorMenuCheck == string.Empty && ErrorAmountCheck == string.Empty || userChoice == 'b' && ErrorMenuCheck == string.Empty && ErrorAmountCheck == string.Empty)
            {
                double SilverBrokenDown = Amount / SilverBreakdownRate;
                Console.WriteLine($"{Amount} Silver Ingot = Silver Ore: {SilverBrokenDown:F2}");//Ingot to Ore
            }

            //Error Checking
            else if (ErrorMenuCheck != string.Empty || ErrorAmountCheck != string.Empty)
            {
                if (ErrorMenuCheck != string.Empty && ErrorAmountCheck == string.Empty)
                {
                    Console.WriteLine($"{ErrorMenuCheck}");
                }
                else if (ErrorMenuCheck == string.Empty && ErrorAmountCheck != string.Empty)
                {
                    Console.WriteLine($"{ErrorAmountCheck}");
                }
                else
                {
                    Console.WriteLine($"{ErrorMenuCheck} and {ErrorAmountCheck}");
                }
            }
        }
    }
}