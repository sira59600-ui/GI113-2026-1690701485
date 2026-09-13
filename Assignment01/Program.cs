/*
 * Student ID : 1690701485
 * Name       : Lab02
 * Section    : 129B
 * No.        : 21
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string GameStartingTitle = "         \"GAME\"";
            string GameTitle = "!! 'Pepo Destruction' !!";
            const string StartingText = "!== Begin Your Journey ==!";

            string CharacterName = "Bobby The Wizard Cheese";
            var BloodType = 'A';
            int CharacterAge = 18;
            float Sanity = 30.75f;
            double AuraPower = 67.67;
            var IsHuman = true;
            bool IsMonster = false;

            Console.WriteLine($"{GameStartingTitle}");
            Console.WriteLine($"{GameTitle}");
            Console.WriteLine($"{StartingText}");

            Console.WriteLine($"Name        : {CharacterName}");
            Console.WriteLine($"BloodType   : {BloodType}");
            Console.WriteLine($"Age         : {CharacterAge}");
            Console.WriteLine($"Sanity      : {Sanity}");
            Console.WriteLine($"AuraPower   : {AuraPower}");

            Console.WriteLine();

            Console.WriteLine($"           \"RACE\"");
            Console.WriteLine($"=-_<°. HUMAN || MONSTER -_>°.=");
            Console.WriteLine($"======= {IsHuman} || {IsMonster} ======="); 

            Console.WriteLine();

            double heroLevelAsDouble = CharacterAge; // implicit — ไม่มี cast
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)AuraPower;               // explicit cast
            int staminaRounded = Convert.ToInt32(AuraPower);      // Convert
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
