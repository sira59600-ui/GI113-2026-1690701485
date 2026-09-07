namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|      NEW ADVENTURE      |");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");

            Console.WriteLine();
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|DIFFICULT CHOOSING TIME!!|");
            Console.WriteLine("+------------------------+");
            Console.Write("Choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}");

            Console.WriteLine();
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|        ITEM SHOP        |");
            Console.WriteLine("+------------------------+");
            Console.Write("How many potion?: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine();
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|     RATE THIS LEVEL     |");
            Console.WriteLine("+------------------------+");
            Console.Write("Rate this level (0-5): ");
            bool isValid2 = double.TryParse(Console.ReadLine(), out double rating);
            Console.WriteLine($"Valid input: {isValid2}");
            Console.WriteLine($"Rating: {rating}");

            Console.WriteLine();
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|   CHARACTER CREATION   |");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer enters the dungeon. Luck {luck}");

        }
    }
}
