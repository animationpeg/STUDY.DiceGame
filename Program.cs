using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine($"You rolled a {playerRandomNum}");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // Pauses program for 1000ms

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine($"Enemy AI rolled a {enemyRandomNum}");

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    Console.WriteLine("draw!");
                }
                Console.WriteLine($"The score is now - Player: {playerPoints}. Enemy: {enemyPoints}");
                Console.WriteLine("");
            }

            // Declare winner of the dice game
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine("Enemy wins!");
            }
            else
            {
                Console.WriteLine("Game ends in a draw!");
            }
            Console.ReadKey();
        }
    }
}
