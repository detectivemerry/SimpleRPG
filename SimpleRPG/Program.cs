using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

namespace SimpleRPG 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton class, player health is used to calculate damage for various Monster sub-classes
            Player player = Player.GetPlayerInstance();

            List<Monster?> leagueOfVillians = new List<Monster?>
            {
                MonsterFactory.GetMonster("Bandit"),
                MonsterFactory.GetMonster("Goblin"),
                MonsterFactory.GetMonster("Dragon"),
            };

            Dictionary<string, string> playerOptions = new Dictionary<string, string>
            {
                {"1. Attack Monster", "attack"},
                {"2. Quit", "quit"},
            };

            while(player.Health > 0 && leagueOfVillians.Count > 0)
            {
                int choice = GetInputFromPlayer(playerOptions);

                switch (choice)
                {
                    case 1:

                        Monster? currentMonster = leagueOfVillians[0];

                        if (currentMonster != null)
                        {
                            PrintPreBatleStatus(player, currentMonster);
                            
                            player.AttackMonster(currentMonster);
                            currentMonster.AttackPlayer(player);

                            PrintPostBatleStatus(player, currentMonster);

                            if(currentMonster.Health <= 0)
                            {
                                leagueOfVillians.Remove(currentMonster);
                                Console.WriteLine($"{player.Name} has defeated {currentMonster.Name}!");
                            }
                            if(player.Health <= 0)
                            {
                                Console.WriteLine($"{player.Name} was defeated by {currentMonster.Name}. Try again next time!");
                                return;
                            }   
                        }
                        break;
                    case 2:
                        Console.WriteLine("You have quit the game.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                if(leagueOfVillians.Count == 0)
                {
                    Console.WriteLine("Congratulations, you won!");
                }
                string divider = new string('-', 50);
                Console.WriteLine(divider);

            }

        }

        static int GetInputFromPlayer(Dictionary<string, string> options)
        {
            Console.WriteLine("\nOptions:");

            foreach (string option in options.Keys)
            {
                Console.WriteLine(option);
            }

            Console.Write("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintPreBatleStatus(Player player, Monster currentMonster)
        {
            Console.Write("\nBefore Battle\n");
            Console.WriteLine($"{player.Name} is facing off against {currentMonster.Name}");
            Console.WriteLine($"Player health: {player.Health}");
            Console.WriteLine($"Monster health: {currentMonster.Health}");
            Console.Write("\n");
        }

        static void PrintPostBatleStatus(Player player, Monster currentMonster)
        {
            Console.Write("\nAfter Battle\n");
            Console.WriteLine($"{player.Name}'s Health: {player.Health}");
            Console.WriteLine($"{currentMonster.Name}'s Health: {currentMonster.Health}");
            Console.Write("\n");
        }
    }
}