using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public abstract class Monster
    {
        private double _health;
        public double Health
        {
            get { return Math.Round(_health, 1); }
            set { _health = Math.Round(value, 1); }
        }
        public string Name { get; set; } = String.Empty;
        public abstract void PrintOpeningLine();
        public abstract void PrintDeathScream();
        public abstract void AttackPlayer(Player player);
    }
}
