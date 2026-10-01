namespace assignment_2
{
    // ==========================================
    // Student ID : 68000000
    // Name       : John Doe
    // Section    : 01
    // No.        : 12
    // ==========================================

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Declaring required constants (PascalCase)
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            // Displaying header and menu
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("=> " + MaterialName + " Smelting " + SmeltRate + " / Salvage " + SalvageRate);
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            // Reading inputs using TryParse
            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            char menu;
            bool isMenuValid = char.TryParse(menuInput, out menu);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            double amount;
            bool isAmountValid = double.TryParse(amountInput, out amount);

            // Nested if-else structure with && and || conditions
            if (isAmountValid && (amount > 0 && amount <= MaxBatch))
            {
                if (isMenuValid && (menu == 'S' || menu == 's'))
                {
                    double result = amount * SmeltRate;
                    Console.WriteLine("=> " + amount.ToString("F2") + " " + MaterialName + " Ore = " + result.ToString("F2") + " " + MaterialName + " Ingot");
                }
                else if (isMenuValid && (menu == 'B' || menu == 'b'))
                {
                    double result = amount / SalvageRate;
                    Console.WriteLine("=> " + amount.ToString("F2") + " " + MaterialName + " Ingot = " + result.ToString("F2") + " " + MaterialName + " Ore");
                }
                else
                {
                    Console.WriteLine("error: menu");
                }
            }
            else
            {
                Console.WriteLine("error: amount");
            }
        }
    }
}
