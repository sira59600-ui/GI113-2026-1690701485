namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var IronSmeltRate = 0.2500;
            var IronBreakdownRate = 0.3000;

            var SilverRate = 0.5;
            var SilverBreakdownRate = 0.8;

            Console.WriteLine("Startoooooo!!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("S For Smelt");
            Console.WriteLine("B For Breakdown");
            Console.Write("Choose : ");

            bool Choice = char.TryParse(Console.ReadLine(), out char userChoice);
            Console.WriteLine();
            if (userChoice == 'S' || userChoice == 's')
            {
                Console.WriteLine("You Choose Smelt");

            }
            else if (userChoice == 'B' || userChoice == 'b')
            {
                Console.WriteLine("You Choose Breakdown");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 'S' for Smelt or 'B' for Breakdown.");
            }

            Console.Write("Choose amount: ");
            bool AmountInput = double.TryParse(Console.ReadLine(), out double Amount);
            Console.WriteLine($"Your amount: {Amount}");

            if (userChoice == 'S' || userChoice == 's')
            {
                double IronSmelted = Amount * IronSmeltRate;
                Console.WriteLine($"{Amount} Iron Ore = Iron Ingot: {IronSmelted}");//Ore to Ingot
            }
            else if (userChoice == 'B' || userChoice == 'b')
            {
                double IronBrokenDown = Amount / IronBreakdownRate;
                Console.WriteLine($"{Amount} Iron Ingot = Iron Ore: {IronBrokenDown}");//Ingot to Ore
            }
        }
    }
}