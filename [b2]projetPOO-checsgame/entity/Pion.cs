using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Pion : Entity
    {
        public Pion(bool color) : base(color)
        { }
        public override void Print()
        {
            if (this.color == true) { new Print(" p", ConsoleColor.Blue); }
            else { new Print(" p", ConsoleColor.Red); }
        }
    }
}
