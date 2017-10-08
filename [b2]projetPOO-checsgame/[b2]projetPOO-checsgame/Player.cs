using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame
{
    class Player
    {
        protected string name;
        protected bool color;
        public Player(string name, bool color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
