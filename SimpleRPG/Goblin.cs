using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    internal class Goblin : Monster
    {
        public Goblin()
        {
            Health = 100;
            Name = "Goblin";
        }
        public override void AttackPlayer(Player player)
        {
            Random random = new Random();
            int attackChoice = random.Next(2);
            double attack = 0;

            if (attackChoice == 0)
            {
                attack = player.Health * 0.01;
                Console.WriteLine("Globin attacks with Immense Golbin Song attack!");
            }
            else
            {
                attack = 50;
                Console.WriteLine("Globin attacks with the mighty spear!");
            }

            player.Health -= attack;
        }

        public override void PrintDeathScream()
        {
            Console.WriteLine("You won't be so lucky next time..");
        }

        public override void PrintOpeningLine()
        {
            Console.WriteLine("Hand over your gold to the mighty Goblin!");
        }
    }
}
