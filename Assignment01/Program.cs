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
            var GameStartingTitle = "         \"GAME\""; //Varตัวที่1
            string GameTitle = "!! 'Pepo Destruction' !!";
            const string StartingText = "!== Begin Your Journey ==!"; //Const

            string CharacterName = "Bobby The Wizard Cheese";
            char BloodType = 'A'; 
            int CharacterAge = 18;
            float Sanity = 30.75f;
            double AuraPower = 67.67;
            var IsHuman = true; //Varตัวที่2
            bool IsMonster = false;

            Console.WriteLine($"        {GameStartingTitle}");
            Console.WriteLine($"         {GameTitle}");
            Console.WriteLine($"        {StartingText}");

            Console.WriteLine();

            Console.WriteLine($"===========================================");
            Console.WriteLine($" ||       \"YOUR CHARACTER STATS\"        ||");
            Console.WriteLine($" ||                                     ||");

            Console.WriteLine($" ||Name        : {CharacterName}||");
            Console.WriteLine($" ||BloodType   : {BloodType}                      ||");
            Console.WriteLine($" ||Age         : {CharacterAge}                     ||");
            Console.WriteLine($" ||Sanity      : {Sanity}                  ||");
            Console.WriteLine($" ||AuraPower   : {AuraPower}                  ||");
            Console.WriteLine($"===========================================");

            Console.WriteLine();

            Console.WriteLine($"                 \"RACE\"");
            Console.WriteLine($"      =-_<°. HUMAN || MONSTER -_>°.=");
            Console.WriteLine($"      ======= {IsHuman} || {IsMonster} ======="); 

            Console.WriteLine();

            Console.WriteLine($"-------------------------------------------");
            int AuraPowerAsInt = (int)AuraPower; //Explicit Cast
            int AuraRounded = Convert.ToInt32(AuraPower); //Convert
            Console.WriteLine($"AuraPowerAsInt (Explicit Cast) : {AuraPowerAsInt}");
            Console.WriteLine($"AuraRounded (Convert) : {AuraRounded}");

            float CharacterAgeAsFloat = CharacterAge; //Implicit Conversion
            Console.WriteLine($"CharacterAge as float (implicit): {CharacterAgeAsFloat}");
            Console.WriteLine($"-------------------------------------------");
        }
    }
}
