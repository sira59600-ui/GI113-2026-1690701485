namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int CurrentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}\n" +
               $"Rank: {rank}\n" +
               $"Level: {level}\n" +
               $"HP: {CurrentHp} / {maxHp}\n" +
               $"Attack Power: {attackPower}\n" +
               $"Crit Multiplier: {critMultiplier}\n" +
               $"Is Boss: {isBoss}");

            Console.WriteLine();

            int hpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent : {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Kirin take 60 damage!");
            CurrentHp = CurrentHp - 60;

            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {CurrentHp}/{maxHp}");
            int newhpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent : {newhpPercentage}%");

            /////////////////////////////////////////////////Part B Random Monster to kill it and then get loot and exp

            // Add many monster names
            string[] monsterNames = new[]
            {
               "Succubus","Cerberus","Troll","Manticore","Naga"
            };

            // Pick a random monster to appear
            var rnd = new Random();
            string MonsterName = monsterNames[rnd.Next(monsterNames.Length)];
            Console.WriteLine(MonsterName + " appears!");


        }
    }
}
