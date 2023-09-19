using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public sealed class Player
    {

        private static Player? instance = null;

        private double _health;

        public double Health
        {
            get { return Math.Round(_health, 1); }
            set { _health = Math.Round(value, 1); }
        }

        public string Name { get; set; }

        public double Attack { get; set; }
        private Player()
        {
            Name = "The shining knight artix";
            Health = 1000;
            Attack = 100;
        }

        public static Player GetPlayerInstance()
        {
            if(instance == null)
            {
                instance  = new Player();
            }
            return instance;
        }

        public void AttackMonster(Monster? monster)
        {
            if(monster != null)
            {
                monster.Health -= Attack;
            }
            Console.WriteLine("Player attacks the monster with Forceful Slash!");
        }

        public override string ToString()
        {
            return $"Name: {Name} Current Health: {Health}";
        }

        
    }
}
