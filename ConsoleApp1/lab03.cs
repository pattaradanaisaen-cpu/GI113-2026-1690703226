namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("====== KIRIN SAVE CONVERTER ======");
            Console.WriteLine($" NAME: {bossName}"+
            $"\nRank:{rank}" +
            $"\nLevel:{level}/{MaxLevel}" +
            $"\nHp:{currentHp} /{maxHp}" +
            $"\nCrit multiplier{critMultiplier}" +
            $"\nisboss:{isBoss}");
            //Imp;icit Coversion unt (Hp) -->> double
            double currentHpDouble = currentHp;
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            Console.WriteLine($"HP (double):{currentHpDouble}");

            //Calculate Prcentago
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (exact): {hpPercentExact}%");

            //Explicit float (attackPower) -->> int
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");
            // Cast vs. Convert double (critMultiplier) -->> int
            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");

        }
    }
}
