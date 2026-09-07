namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|      NEW ADVENTURE|      ");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");

            Console.Write("Choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}");
        }
    }
}
