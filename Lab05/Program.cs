namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GAME");
            Console.WriteLine("CreativeMan");

            //User input of Hero stats
            Console.Write("Hero Health: ");
            bool isHeroHP = int.TryParse(Console.ReadLine(), out int heroHP);
            Console.Write("Hero Attack: ");
            bool isHeroATK = int.TryParse(Console.ReadLine(), out int heroATK);
            Console.Write("Hero Defense: ");
            bool isHeroDEF = int.TryParse(Console.ReadLine(), out int heroDEF);

            //User input of Monster stats
            Console.Write("Monster Health: ");
            bool IsMonsterHP = int.TryParse(Console.ReadLine(), out int monsterHP);
            Console.Write("Monster Attack: ");
            bool IsMonsterATK = int.TryParse(Console.ReadLine(), out int monsterATK);
            Console.Write("Monster Defense: ");
            bool IsMonsterDEF = int.TryParse(Console.ReadLine(), out int monsterDEF);

            //Check if player input is valid
            bool allHeroValid = isHeroHP && isHeroATK && isHeroDEF;
            bool allMonsterValid = IsMonsterHP && IsMonsterATK && IsMonsterDEF;
            Console.WriteLine($"Stats Validation: HERO: {allHeroValid}, MONSTER: {allMonsterValid}");
            Console.WriteLine($"[HERO]    HP: {heroHP}, ATK: {heroATK}, DEF: {heroDEF}");
            Console.WriteLine($"[MONSTER] HP: {monsterHP}, ATK: {monsterATK}, DEF: {monsterDEF}");

            //Before fighting: Hero drinks a potion (Conpoud Assignment)
            int potionHeal = 0;
            // 1.
            //heroHp = heroHp + potionHeal;
            // 2.
            heroHP += potionHeal;// แนะนำแบบนี้ คำนวณเหมือนกับ 1 = 1+2
            Console.WriteLine($"Hero drinks a potion, Healing: {potionHeal}HP. health is now {heroHP}");
            int normalDamage = Math.Max(0, heroATK - monsterDEF);
            Console.WriteLine($"Normal attack deal: {normalDamage}");
        }
    }
}