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
            //
            string name1 = "Arthur";         
            int hp1 = 1500;               
            double defense1 = 85.50;       
            float speed1 = 2.5f;            
            char rank1 = 'S';
            
            Console.WriteLine($"Name: {name1}");
            Console.WriteLine($"HP: {hp1}");
            Console.WriteLine($"Defense: {defense1}");
            Console.WriteLine($"Speed: {speed1} m/s");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine();
            //
            string name2 = "Merlin";
            int mp2 = 800;
            double magicDamage2 = 340.75;
            bool isBoss2 = false;
            char rank2 = 'A';
          
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"MP: {mp2}");
            Console.WriteLine($"Magic Damage: {magicDamage2}");
            Console.WriteLine($"Is Boss: {isBoss2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine();
            //
            string name3 = "Shadow";
            float criticalRate3 = 45.8f;
            double attackSpeed3 = 1.95;
            bool isStealth3 = true;
            int level3 = 50;
           
            Console.WriteLine($"Name: {name3}");
            Console.WriteLine($"Critical Rate: {criticalRate3}%");
            Console.WriteLine($"Attack Speed: {attackSpeed3} atk/s");
            Console.WriteLine($"Stealth Mode: {isStealth3}");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine();
            //
            string name4 = "Ignis";
            int hp4 = 99999;
            float height4 = 12.4f;
            bool isBoss4 = true;
            char element4 = 'F';
          
            Console.WriteLine($"Name: {name4}");
            Console.WriteLine($"HP: {hp4}");
            Console.WriteLine($"Height: {height4} meters");
            Console.WriteLine($"Is Boss: {isBoss4}");
            Console.WriteLine($"Element: {element4}");

        }
    }
}
