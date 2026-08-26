/*
 * Student ID :1690703226
 * Name       : Lab02
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====\r\n");
            Console.WriteLine($"Name:{bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"AttackPowe:{attackPower}");
            Console.WriteLine($"crit Multiplier: {critMultiplier}");
            Console.WriteLine($"is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercrnt = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercrnt}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            hpPercrnt = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercrnt}%");


        }
    }
}
