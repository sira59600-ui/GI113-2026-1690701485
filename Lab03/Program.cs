/*
 * Student ID : 1690701485
 * Name       : Lab02
 * Section    : 129B
 * No.        : 21
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";
            var rank = "S";
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"NAME: {bossName}" +
            $"\nRANK: {rank}" +
            $"\nLEVEL: {level} / {MaxLevel}" +
            $"\nHP: {currentHp} / {maxHp}" +
            $"\nATTACK POWER: {attackPower}" +
            $"\nCRIT MULTIPLIER: {critMultiplier}" +
            $"\nIS BOSS: {isBoss}");

            // Implicit Conversion HP (int) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            //Calculate Percentage as double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentageExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentageExact}%");

            // Explicit casting attack power (float) -->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            // Cast vs. Convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
