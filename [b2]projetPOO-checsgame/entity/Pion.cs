using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Pion : Entity
    {
        private int[,] mvlist = new int[1, 2];
        public Pion(bool color) : base(color){}
        public override string Get()
        { return " p"; }
    }
}
