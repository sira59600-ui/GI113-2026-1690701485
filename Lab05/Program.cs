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

            //คำนวณ damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, heroATK - monsterDEF);
            Console.WriteLine($"Normal attack deal: {normalDamage} DMG");

            //คำนวณ power attack (Predence ลำดับการคำนวญ คูณก่อนที่จะลบ)
            int powerDamage = Math.Max(0, (heroATK * 2) - monsterDEF); // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี ()
            Console.WriteLine($"Power attack deal: {powerDamage} DMG");

            //คำนวญ Monster attack
            int counterDamage = Math.Max(0, (monsterATK / 2) - heroDEF);
            Console.WriteLine($"Monster counter attack deal: {counterDamage} DMG");

            Random rng = new Random();
            int roll = rng.Next(1, 101);
            bool isCritical = roll <= 10; // 10%
            int critDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"Critical hit roll : {roll} (Critical: {isCritical})");
            Console.WriteLine($"Normal attack would deal Critical: {critDamage} DMG");
        }
    }
}