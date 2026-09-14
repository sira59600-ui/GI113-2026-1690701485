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
            var GameStartingTitle = "         GAME"; //Var ตัวที่1 แทน string     
            const string StartingText = "!== Begin Your Journey ==!"; //const

            string CharacterName = "Bobby The Wizard Cheese";
            char BloodType = 'A'; 
            var CharacterGender = 'M'; //Var ตัวที่2 แทน char
            int CharacterAge = 18;
            float Sanity = 30.75f;
            double AuraPower = 67.67;
            var IsHuman = true; //Var ตัวที่3 แทน bool
            bool IsMonster = false;

            Console.WriteLine();
            Console.WriteLine($"╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                                                                                        ║");
            Console.WriteLine($"║                                                                          {GameStartingTitle} ║");
            Console.WriteLine($"║                                                                                        ║");
            Console.WriteLine($"████  █████ ████   ███     ████  █████  ████ █████ ████  █   █  ███  █████ ███  ███  █   █");
            Console.WriteLine($"█░░░█ █░░░░░█░░░█ █ ░░█    █░░░█ █░░░░░█ ░░░░ ░█░░░█░░░█ █░  █░█ ░░░  ░█░░░ █░░█ ░░█ ██  █░");  
            Console.WriteLine($"████░░████░░████░░█░ ░█░   █░░░█░████░░░███░░░ █░░░████░░█░░ █░█░ ░░░  █░░░░█░░█░ ░█░█░█ █░░"); 
            Console.WriteLine($"█░░░░ █░░░░ █░░░░ █░░ █░░  █░░ █░█░░░░   ░░█   █░░ █░░█░ █░░ █░█░░     █░░  █░░█░░ █░█░░██░░"); 
            Console.WriteLine($"█░░░░░█████░█░░░░░ ███ ░░  ████ ░█████░████░░  █░░ █░░░█░ ███ ░░███    █░░ ███░ ███ ░█░░ █░░"); 
            Console.WriteLine($"░░    ░░░░░ ░░     ░░░ ░   ░░░░ ░░░░░░ ░░░░ ░  ░░  ░░  ░  ░░░ ░ ░░░    ░░  ░░░  ░░░ ░░░  ░░"); 
            Console.WriteLine($"░     ░░░░░ ░      ░░░     ░░░░  ░░░░░ ░░░░    ░   ░   ░  ░░░   ░░░    ░   ░░░  ░░░  ░   ░"); 
            Console.WriteLine($"║                                                                                        ║");
            Console.WriteLine($"║                                                                                        ║");
            Console.WriteLine($"║                                                                                        ║");
            Console.WriteLine($"╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"{StartingText}");
            Console.WriteLine($"╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                 YOUR CHARACTER STATS & ATTRIBUTES                   ║");
            Console.WriteLine($"╚═════════════════════════════════════════════════════════════════════╝");

            Console.WriteLine($"Name        : {CharacterName}");
            Console.WriteLine($"BloodType   : {BloodType}");
            Console.WriteLine($"Gender      : {CharacterGender}");
            Console.WriteLine($"Age         : {CharacterAge}");
            Console.WriteLine($"Sanity      : {Sanity}%");
            Console.WriteLine($"AuraPower   : {AuraPower}");

            Console.WriteLine($"╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                              YOUR RACE                              ║");
            Console.WriteLine($"╚═════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine($"HUMAN   : {IsHuman}");
            Console.WriteLine($"MONSTER : {IsMonster}");
            Console.WriteLine();

            Console.WriteLine($"╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                        TYPE CONVERSION ANALYSIS                     ║");
            Console.WriteLine($"╚═════════════════════════════════════════════════════════════════════╝");
            int AuraPowerAsInt = (int)AuraPower; //Explicit Cast
            int AuraRounded = Convert.ToInt32(AuraPower); //Convert
            Console.WriteLine($"AuraPower (Explicit Cast)  : {AuraPowerAsInt}");
            Console.WriteLine($"AuraPower (Convert)        : {AuraRounded}");

            float CharacterAgeAsFloat = CharacterAge; //Implicit Conversion
            Console.WriteLine($"CharacterAge (Implicit)    : {CharacterAgeAsFloat}");

            Console.WriteLine();
            Console.WriteLine($"                                           ██████                                 ");
            Console.WriteLine($"                                      █ █ ██    █████                             ");
            Console.WriteLine($"                           █   █   ██████ ██     █████                            ");
            Console.WriteLine($"                    ███████     ███  ██ █ █████  █   ██    ███    ████            ");
            Console.WriteLine($"                  █████    █  ███████    █ ███ █     ███   ████     ████          ");
            Console.WriteLine($"                █████ █       ██   █  ██  █   █         ██     █  ██  ███         ");
            Console.WriteLine($"               ████   █████████  ████             ███   ████   ██   ██  ██        ");
            Console.WriteLine($"      █           █   ██████████████████    █       ███████    █████ ████         ");
            Console.WriteLine($"     █           █              ██████████   █    ████    ████████████     ██████ ");
            Console.WriteLine($" █              ██                   ███████    ████               ██████████████ ");
            Console.WriteLine($" █           █████                                             ███   ███ ████     ");
            Console.WriteLine($" ████████████████                                           ███        █ ██       ");
            Console.WriteLine($"  ████████████                                                ████     ███        ");
            Console.WriteLine($"        ███   ██████                                                              ");
            Console.WriteLine($" █          █ ████████                                                            ");
            Console.WriteLine($"           █                                                                      ");
            Console.WriteLine($"         ██                                                                       ");
            Console.WriteLine($"        ███       ████                                                            ");
            Console.WriteLine($"        █        █  ██                                                            ");
            Console.WriteLine($"             █ █ ██                                               ████            ");
            Console.WriteLine($"       █     █                           ████                   ███████           ");
            Console.WriteLine($"       █    ██  █                       ███████               █████████           ");
            Console.WriteLine($"        █████                           ███ ████            █████    ██           ");
            Console.WriteLine($"          ██                            ███  ███████████████████    ███          ");
            Console.WriteLine($"                                         ██    ███████████████     ████           ");
            Console.WriteLine($"                                         ██ ███  ██        ██  █   ███            ");
            Console.WriteLine($"                                        ██████████       █ █ █████ ███            ");
            Console.WriteLine($"                                       █████████ ██       ███  ███ ███            ");
            Console.WriteLine($"                                       ████   ███ ██     ██  ████  ███            ");
            Console.WriteLine($" ███                                  ███    ███ █  █████  ██    ██ ███           ");
            Console.WriteLine($" ███████████████████████████████████████        █████ █ █████       █████████████ ");
            Console.WriteLine($" ███████████████████████████████████████ ████      ███ ███      ████ ████████████ ");
            Console.WriteLine($"                        ███████████████         ████████████         ████████████ ");
            Console.WriteLine($"                                                   █               █████          ");
            Console.WriteLine($"                                               ████       █       ██  █           ");
            Console.WriteLine($"                                                     ██        ███     █          ");
            Console.WriteLine($"                                         ██   ██████ ██  ██████        █          ");
            Console.WriteLine($"                                     ██  ██████████  ██  █             █          ");
            Console.WriteLine($"                                    ██                   ██            █          ");
            Console.WriteLine($"                                    ██                                 ██         ");
            Console.WriteLine($"                                     █                             ██  █          ");
        }
    }
}
