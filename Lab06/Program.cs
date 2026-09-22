/*
* Student ID : 1690701485
* Name       : Lab06
* Section    : 129B
* No.        : 21
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int CoinValue = 10;
            char ChoiceYN;
            bool ShopChoices;

            Console.WriteLine($"You have : {CoinValue} Coins");
            Console.WriteLine($"Enter the number of coins to withdraw: ");
            Console.Write("Withdraw : ");
            bool C = int.TryParse(Console.ReadLine(), out int Coin);
            if (!C || Coin > 10)
            {
                Console.WriteLine("You Don't have that much of coins");
                Coin = 10;
            }
            else if (Coin < 0)
            {
                Console.WriteLine("You can't withdraw negative coins");
                Coin = 10;
            }
            Console.WriteLine($"You withdraw {Coin} Coins");
            Console.WriteLine();
            Console.WriteLine("Go Next>? Y or N");
            Console.Write("Enter : ");
            ChoiceYN = Console.ReadLine()[0];
            //----------------------------------------------------------------------------------------------------------------------------------------------------------
            //Yes
            //----------------------------------------------------------------------------------------------------------------------------------------------------------
            if (ChoiceYN == 'Y' || ChoiceYN == 'y')
            {
                Console.WriteLine();
                Console.WriteLine("Use your Coin on which shop?");
                Console.WriteLine("Flower Shop : 5 Coins");
                Console.WriteLine("Food Shop : 3 Coins");
                Console.WriteLine("Game Shop : 10 Coins");
                Console.Write("Enter your choice (1-3) : ");
                ShopChoices = int.TryParse(Console.ReadLine(), out int Shop);
                Console.WriteLine();
                if (Shop == 1 && Coin >= 5)
                {
                    Console.WriteLine("You have used 5 Coins on Flower Shop");
                    Console.WriteLine($"You got a flower and then you give it to a girl now you got a girlfriend too!! and You have {Coin - 5} Coins left");
                }
                else if (Shop == 1 && Coin < 5)
                {
                    Console.WriteLine($"You don't have enough coins to buy from Flower Shop!");
                }
                else if (Shop == 2 && Coin >= 3)
                {
                    Console.WriteLine("You have used 3 Coins on Food Shop");
                    Console.WriteLine($"You have a delicious meal and feel satisfied! and You have {Coin - 3} Coins left");
                }
                else if (Shop == 2 && Coin < 3)
                {
                    Console.WriteLine($"You don't have enough coins to buy from Food Shop!");
                }
                else if (Shop == 3 && Coin >= 10)
                {
                    Console.WriteLine("You have used 10 Coins on Game Shop");
                    Console.WriteLine($"You got your favorite game and play it all day then having fun with it! and You have {Coin - 10} Coins left");
                }
                else if (Shop == 3 && Coin < 10)
                {
                    Console.WriteLine($"You don't have enough coins to buy from Game Shop!");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    Console.WriteLine($"Then You Choose to keep your Coins and got nothing");
                }
            }
//----------------------------------------------------------------------------------------------------------------------------------------------------------
//No
//----------------------------------------------------------------------------------------------------------------------------------------------------------
            else if (ChoiceYN == 'N' || ChoiceYN == 'n')
            {
                Console.WriteLine();
                Console.WriteLine($"Then You Choose to keep your Coins and got nothing");
            }
//----------------------------------------------------------------------------------------------------------------------------------------------------------
//Incase of valid input
//----------------------------------------------------------------------------------------------------------------------------------------------------------
            else
            {
                Console.WriteLine();
                Console.WriteLine($"!Invalid input!");
                Console.WriteLine($"Then go next instead! ");

                Console.WriteLine();
                Console.WriteLine("Use your Coin on which shop?");
                Console.WriteLine("Flower Shop : 5 Coins");
                Console.WriteLine("Food Shop : 3 Coins");
                Console.WriteLine("Game Shop : 10 Coins");
                Console.Write("Enter your choice (1-3) : ");
                ShopChoices = int.TryParse(Console.ReadLine(), out int Shop);
                Console.WriteLine();
                if (Shop == 1 && Coin >= 5)
                {
                    Console.WriteLine("You have used 5 Coins on Flower Shop");
                    Console.WriteLine($"You got a flower and then you gave it to a girl and now you happy and got a girlfriend too!! and You have {Coin - 5} Coins left");
                }
                else if (Shop == 1 && Coin < 5)
                {
                    Console.WriteLine($"You don't have enough coins to buy from Flower Shop!");
                }
                else if (Shop ==2 && Coin >= 3)
                {
                    Console.WriteLine("You have used 3 Coins on Food Shop");
                    Console.WriteLine($"You have a delicious meal and feel satisfied! and You have {Coin - 3} Coins left");
                }
                else if (Shop == 2 && Coin < 3)
                {
                    Console.WriteLine($"You don't have enough coins to buy from Food Shop!");
                }
                else if (Shop == 3 && Coin >= 10)
                {
                    Console.WriteLine("You have used 10 Coins on Game Shop");
                    Console.WriteLine($"You got your favorite game and play it all day then have fun with it! and You have {Coin - 10} Coins left");
                }
                else if (Shop == 3 && Coin < 10)
                {
                    Console.WriteLine($"You don't have enough coins to buy from Game Shop!");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    Console.WriteLine($"Then You Choose to keep your Coins and got nothing");
                }
            }
        }
    }
}
