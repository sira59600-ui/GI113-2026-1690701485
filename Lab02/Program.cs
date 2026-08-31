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

            Console.WriteLine();
            Console.Write("===== PART B: Random Monster Encounter! =====");
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string PlayerName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(PlayerName)) PlayerName = "Player";
            Console.WriteLine($"{PlayerName} has encountered a random monster!");
            
            Console.WriteLine();

            Console.Write("Choose your weapon (Sword or Bow or Staff): ");
            string WeaponName = Console.ReadLine();
            float DMG = 0.0f;

            if (string.IsNullOrWhiteSpace(WeaponName))
            {
                WeaponName = "Fists";
            }

            if (WeaponName == "Sword")
            {
                DMG = Random.Shared.Next((int)35.00f, (int)100.00f);
            }
            else if (WeaponName == "Bow")
            { 
                DMG = Random.Shared.Next((int)50.00f, (int)85.00f);
            }
            else if (WeaponName == "Staff")
            { 
                DMG = Random.Shared.Next((int)30.00f, (int)120.00f);
            }
            else
            {
                WeaponName = "Fists";
                DMG = Random.Shared.Next((int)15.00f, (int)30.00f);
            }

            Console.WriteLine($"{PlayerName} is using {WeaponName}!");
            Console.WriteLine($"Weapon Damage : {DMG}");

            Console.WriteLine();

            // Add monster names
            string[] monster = new[]
            {
               "Succubus","Cerberus","Troll","Naga"
            };
            string[] loots = new[]
            {
                "Weapon","Armor","Potion"
            };

            // Pick a random monster to appear
            var rnd = new Random();
            string MonsterName = monster[rnd.Next(monster.Length)];
            string loot = loots[rnd.Next(loots.Length)];
            int Hp = rnd.Next(70,250);

            if (MonsterName == "Succubus")
            {
                Console.WriteLine($"A {MonsterName} with {Hp} HP appears!");
                //Console.WriteLine("You killed the Succubus!");
                // Console.WriteLine("You got 100 gold and 50 exp!");
                //Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Cerberus")
            {
                Console.WriteLine($"A {MonsterName} with {Hp} HP appears!");
                // Console.WriteLine("You killed the Cerberus!");
                // Console.WriteLine("You got 200 gold and 100 exp!");
                // Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Troll")
            {
                Console.WriteLine($"A {MonsterName} with {Hp} HP appears!");
                // Console.WriteLine("You killed the Troll!");
                //Console.WriteLine("You got 150 gold and 75 exp!");
                //Console.WriteLine($"You also found a {loot}!");
            }
            else if (MonsterName == "Naga")
            {
                Console.WriteLine($"A {MonsterName} with {Hp} HP appears!");
                // Console.WriteLine("You killed the Naga!");
                //Console.WriteLine("You got 250 gold and 125 exp!");
                // Console.WriteLine($"You also found a {loot}!");

            }

            Console.Write("Attack? (Y/N): ");
            string attackChoice = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(attackChoice))
            {
                attackChoice = "N";
            }

            if (attackChoice == "Y" || attackChoice == "y")
            {
                Console.WriteLine("You attacked the monster!");
            }
            else if (attackChoice == "N" || attackChoice == "n")
            {
                Console.WriteLine("You chose not to attack.");
            }
            else
            {
                Console.WriteLine("Invalid input! Defaulting to No Attack.");
            }

        }
    }
}