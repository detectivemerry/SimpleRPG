using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    internal class Dragon : Monster
    {
        public Dragon() 
        {
            Health = 500;
            Name = "Dragon";
        }

        public override void AttackPlayer(Player player)
        {
            Random random = new Random();
            int attackChoice = random.Next(2);
            double attack = 0;

            if (attackChoice == 0)
            {
                attack = player.Health * 0.33;
                Console.WriteLine("Fire breath attack!");
            }
            else
            {
                attack = 50;
                Console.WriteLine("Dragon claws attack!");
            }

            player.Health -= attack;

        }

        public override void PrintDeathScream()
        {
            Console.WriteLine("This is not the end...");
        }

        public override void PrintOpeningLine()
        {
            Console.WriteLine("You shall face the wrath of the thousand scales!");
        }
    }
}
