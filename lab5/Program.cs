namespace lab5
{
    internal class Program
    {
        private static bool monAtko;

        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> MY GAME DEE <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");
            // Hero stats input HP, ATK, DEF
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkok = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefok = int.TryParse(Console.ReadLine(), out int heroDef);
            // Monster stats input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkok = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Attack: ");
            bool monDefok = int.TryParse(Console.ReadLine(), out int monDef);
            // Input validation
            bool isHeroIntValid = heroHpOk && heroAtkok && monHpOk;
            bool isMonIntValid = monHpOk && monAtkok && monDefok;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonIntValid}");
            Console.WriteLine($" [HERO] HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: { monHp}  ATK: { monAtk}DEF:{monDef}    ");

            //bool allIntValid = !isHeroIntValid && isMonIntValid;
            // If you only check the bool value, it checks if it's true. But if you put an exclamation mark (!) in front of it, it's the opposite (true -> false).
            // Compound assignment: += Simulate a situation where a player drinks a potion before combat.
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal;
            // long form
            heroHp += potionHeal;
            // Short version, same meaning: Combine potionHeal with heroHP.
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP. Hero HP now {heroHp} HP");
            // Arithmetic + Normal attack
            int normDmg = Math.Max(0, heroAtk - monDef);   // The attack strength depends on the enemy's defense value.
            Console.WriteLine($"\nNormal Attack would deal: {normDmg} DMG");
            // Precedence of special attacks
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef);
            // The x2 attack is optional; you can use a small circle or not because the multiplier is applied first.
            Console.WriteLine($"Power Attack would deal: {pwrDmg} DMG");
            // Random, Simple percent of critical chance.
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101);
            //Always add 1 to the maximum value. For example, if you want 100, you need 101.
            bool isCrit = roll <= 10; // 10% Chance out of 100
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg;
            // Bool 1 or 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"If cirical, normal attack would instead deal: {critDmg}");


























        }
    }
}
