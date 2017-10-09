using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Pion : Entity
    {
        private int[,] mv = new int[1, 2];
        public Pion(bool color) : base(color)
        {
            if (this.color) { mv[0, 0] = 1; }
            else { mv[0, 0] = -1; }
            mv[0, 1] = 0;
        }
        public override int[,] Att(int[] s)
        {
            int[,] att = new int[2, 2];
            if (this.color) { att[1, 0] = (1 + s[0]); }
            else { att[1, 0] = (-1 + s[0]); }
            att[1, 1] = (1 + s[1]);

            if (this.color) { att[0, 0] = (1 + s[0]); }
            else { att[0, 0] = (-1 + s[0]); }
            att[0, 1] = (-1 + s[1]);
            return att;
        }
        public override string Get()
        { return " p"; }
    }
}
