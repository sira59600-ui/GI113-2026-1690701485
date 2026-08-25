namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Supakit";
            char rank = 'F';
            int level = 10;
            int maxHp = 100;
            int CurrentHp = 100;
            float attackPower = 27.5f;
            double critMultiplier = 1.25;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();

            int hpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent : {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Supakit take 20 damage!");
            CurrentHp = CurrentHp - 20;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {CurrentHp}/{maxHp}");
            int newhpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent : {newhpPercentage}%");

        }
    }
}
