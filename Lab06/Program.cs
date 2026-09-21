namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int live = 0;
            if (live <= 0)
            {
                Console.WriteLine("Game Over");
            };
            Console.WriteLine("Continue running");
            //2
            int coins = 100;
            int price = 100;
            if (coins >= price)
            {
                Console.WriteLine("Purchased");
            }
            else
            {
                Console.WriteLine("Not enough coins");
            };
            //3
            int score = 75;
            if (score >= 90 )
            {
                Console.WriteLine("You got rank A!");
            }
            else if (score >= 80 )
            {
                Console.WriteLine("You got rank B!");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got rank C!");
            }
            else if (score >= 60)
            {
                Console.WriteLine("You got rank C!");
            }
            else
            {
                Console.WriteLine("You got rank F!");
            };
            //4
            Console.WriteLine("Your level (1-99)");
            bool ok = int.TryParse(Console.ReadLine(), out int Level);
            if (!ok || Level < 1 || Level > 99)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 99.");
            }
            else if (Level >= 10)
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (Level >= 5)
            {
                Console.WriteLine("The door open");
            }
            else
            {
                Console.WriteLine("Your level is: " + Level);
            }
        }
    }
}
