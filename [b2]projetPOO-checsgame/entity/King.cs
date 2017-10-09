using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class King : Entity
    {
        private int[,] mv = new int[8, 2];
        public King(bool color) : base(color)
        {
            mv[0, 0] = 0;
            mv[0, 1] = 1;
            mv[1, 0] = 1;
            mv[1, 1] = 1;
            mv[2, 0] = 1;
            mv[2, 1] = 0;
            mv[3, 0] = 1;
            mv[3, 1] = -1;
            mv[4, 0] = 0;
            mv[4, 1] = -1;
            mv[5, 0] = -1;
            mv[5, 1] = -1;
            mv[6, 0] = -1;
            mv[6, 1] = 0;
            mv[7, 0] = -1;
            mv[7, 1] = 1;
        }
        public override string Get() { return " k"; }

        public override bool isk()
        { return true; }
    }
}
