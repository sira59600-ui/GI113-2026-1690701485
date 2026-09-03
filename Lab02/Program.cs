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

            /////////////////////////////////////////////////Show Monster Stats
            var rnd = new Random();
            string MonsterName = monster[rnd.Next(monster.Length)];
            string loot = loots[rnd.Next(loots.Length)];
            int MonsterHp = rnd.Next(70, 250);
            double MonsterCrit = 1.5;
            float MonsterDMG = 25.00f + Random.Shared.NextSingle() * (50.00f - 25.00f);
            char Rank = (char)rnd.Next('A', 'B' + 1);
            bool IsEnemy = true;


            Console.WriteLine($"A {MonsterName} with {MonsterHp} HP appears!");
            Console.WriteLine($"Monster Rank: {Rank}\n" +
                $"Monster Damage: {MonsterDMG}\n" +
                $"Monster Crit Multiplier: {MonsterCrit}\n" +
                $"Is Enemy: {IsEnemy}");


            while (MonsterHp > 0)
        {
            Console.Write("Attack? (Y/N): ");
            string attackChoice = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(attackChoice))
            {
                attackChoice = "N";
            }

            if (attackChoice == "Y" || attackChoice == "y")
            {
                Console.WriteLine("You attacked the monster!");
                MonsterHp -= (int)DMG;
                if (MonsterHp > 0)
                    {
                        Console.WriteLine($"The {MonsterName} is still alive with {MonsterHp} HP.");
                    }
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


            if (MonsterHp <= 0)
            {
                Console.WriteLine($"You killed the {MonsterName}!");
                int gold = rnd.Next(50, 300);
                int exp = rnd.Next(25, 150);
                Console.WriteLine($"You got {gold} gold and {exp} exp!");
                Console.WriteLine($"You also found a {loot}!");
            }
        }
    }
}