using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    internal class Bandit : Monster
    {
        public Bandit()
        {
            Health = 150;
            Name = "Bandit";
        }
        public override void AttackPlayer(Player player)
        {
            double attack = player.Health * 0.01;
            player.Health -= attack;
            Console.WriteLine("Bandit attacks with a small dagger!");
        }

        public override void PrintDeathScream()
        {
            Console.WriteLine("Ah! You have bested me, the strongest bandit");
        }

        public override void PrintOpeningLine()
        {
            Console.WriteLine("Muhahaha! I am the strongest bandit. Get ready to fight!");
        }
    }
}
