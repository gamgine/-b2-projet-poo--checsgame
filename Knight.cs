using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Knight : Entity
    {
        private int[,] mv=new int [8,2];
        public Knight(bool color) : base(color)
        {
            mv[0, 0] = 2;
            mv[0, 1] = 2;
            mv[1, 0] = -1;
            mv[1, 1] = 2;
            mv[2, 0] = 1;
            mv[2, 1] = 2;
            mv[3, 0] = 1;
            mv[3, 1] = -2;
            mv[4, 0] = -1;
            mv[4, 1] = 2;
            mv[5, 0] = -1;
            mv[5, 1] = -2;
            mv[6, 0] = -2;
            mv[6, 1] = 1;
            mv[7, 0] = -2;
            mv[7, 1] = -1;
        }
        public override string Get() { return " N"; }

        public override int[,] Mv(int[] s)
        {
            return this.mv;
        }
        public override int[,] Att(int[] s)
        { return this.Mv(s); }
    }
}
