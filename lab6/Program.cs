namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 1;
            if (lives <= 0) // Enter the condition you want to check. The value must be a bool (true / false).
            {
                //The code inside will only run if the `if` statement is true.
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Keep Fighting");
            }
            //If the if statement finishes executing or is false, the next line outside will be executed immediately.
            Console.WriteLine("Continue Code");
            int level = 10;
            // When using multiple case conditions, always check the number from highest to lowest.
            if (level >= 10) // Condition 1
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5) // Condition 2 if condition 1 is not met
            {
                Console.WriteLine("The door opens.");
            }
            else // When none of the conditions are met
            {
                Console.WriteLine("The door stays shut.");
            }
            bool isPosioned = true;
            if (isPosioned == true) // Check if it's true?
            {
                Console.WriteLine("You Died");
            }
            else if (isPosioned == false) // Check if it's false?
            {
                Console.WriteLine("You Lives");
            }
            //int level = 10;
            Console.Write("Your level (1-99): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int leve);
            if (!inputValid || level < 1 || level > 99) //Condition indicating incorrect data
            {
                Console.WriteLine("Invalid Level"); //Warning when user enters incorrect information
            }
            // When using multiple case conditions, always check the numbers from highest to lowest.
            else if (level >= 10) // Condition 1
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5) // Condition 2 if condition 1 is not met
            {
                Console.WriteLine("The door opens.");
            }
            else // When none of the conditions are met
            {
                Console.WriteLine("The door stays shut.");
            }
            int heroHp = 100;
            int monHp = 50;
            int atk = 10;
            int potionHeal = 50;
            Console.WriteLine("==>> ADVENTURE OF BRAIN <<==");
            Console.WriteLine("Hero vs. Monster Actions:");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DRINK HP POTION");
            Console.Write("Choose your action (1-2): ");
            bool userInput = int.TryParse(Console.ReadLine(), out int choice);
            if (!userInput || choice < 1 || choice > 2)
            {
                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Choose a number between 1 2");
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose number between 1-2 only");
                }
            }
            else if (choice == 1) // attack
            {
                monHp -= atk;
                if (monHp <= 0)
                {
                    Console.WriteLine("Monster Defeated!");
                }
                else

                {
                    Console.WriteLine($"Hero Attacked the Monster, Monster have {monHp} HP Left.");
                }
            }
            else if (choice == 2) // Drink HP Potion
            {
                heroHp += potionHeal;
                Console.WriteLine($"Player drank a potion, player now have {heroHp} HP");
            }
        }
    }
}
