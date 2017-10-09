using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Pion : Entity
    {
        private int[,] mv = new int[3, 2];
        public Pion(bool color) : base(color)
        {
            if (this.color) { mv[0, 0] = 1; }
            else { mv[0, 0] = -1; }
            mv[0, 1] = 0;

            if (this.color) { mv[1, 0] = 1; }
            else { mv[1, 0] = -1; }
            mv[1, 1] = 1;

            if (this.color) { mv[2, 0] = 1; }
            else { mv[2, 0] = -1; }
            mv[2, 1] = -1;
        }
        public override string Get()
        { return " p"; }
    }
}
