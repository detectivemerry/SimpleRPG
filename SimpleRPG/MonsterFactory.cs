using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    internal class MonsterFactory
    {
        public static Monster? GetMonster(string monsterType)
        {
            Monster? monster = null;

            if(monsterType == "Goblin")
            {
                monster = new Goblin();
            }
            else if(monsterType == "Bandit")
            {
                monster = new Bandit();
            }
            else if(monsterType == "Dragon")
            {
                monster = new Dragon();
            }

            return monster;
        }
    }
}
