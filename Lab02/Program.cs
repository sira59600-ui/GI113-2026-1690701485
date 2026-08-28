namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////// Part A: Boss Status
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


            ////////////////!!STILL IN PROCESS!!///////////////////////////////



            // Add monster names
            string[] monster = new[]
            {
               "Succubus","Cerberus","Troll","Manticore","Naga"
            };
            string[] loots = new[]
            {
                "Weapon","Armor","Potion"
            };

            // Pick a random monster to appear
            var rnd = new Random();
            string MonsterName = monster[rnd.Next(monster.Length)];
            string loot = "";
            Console.WriteLine(MonsterName + " appears!");

            if (MonsterName == "Succubus")
            {
                Console.WriteLine("You killed the Succubus!");
                Console.WriteLine("You got 100 gold and 50 exp!");
                loot = loots[rnd.Next(loots.Length)];
                Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Cerberus")
            {
                Console.WriteLine("You killed the Cerberus!");
                Console.WriteLine("You got 200 gold and 100 exp!");
                loot = loots[rnd.Next(loots.Length)];
                Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Troll")
            {
                Console.WriteLine("You killed the Troll!");
                Console.WriteLine("You got 150 gold and 75 exp!");
                loot = loots[rnd.Next(loots.Length)];
                Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Manticore")
            {
                Console.WriteLine("You killed the Manticore!");
                Console.WriteLine("You got 300 gold and 150 exp!");
                loot = loots[rnd.Next(loots.Length)];
                Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Naga")
            {
                Console.WriteLine("You killed the Naga!");
                Console.WriteLine("You got 250 gold and 125 exp!");
                loot = loots[rnd.Next(loots.Length)];
                Console.WriteLine($"You also found a {loot}!");

            }

            
        }
    }
}