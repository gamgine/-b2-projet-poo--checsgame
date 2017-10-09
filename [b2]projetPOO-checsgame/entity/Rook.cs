using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Rook : Entity
    {
        private int[,] mv = new int[32,2];
        public Rook(bool color) : base(color)
        {
            for (int i = 0; i < 32; i++)
            {
                if (i < 8)
                {
                    this.mv[i, 0] = 0;
                    this.mv[i, 1] = i;
                }
                if (i > 8 && i < 16)
                {
                    this.mv[i, 0] = i - 8;
                    this.mv[i, 1] = 0;
                }

                if (i > 16 && i < 24)
                {
                    this.mv[i, 0] = 0;
                    this.mv[i, 1] = i - 16;
                }
                if (i > 24)
                {
                    this.mv[i, 0] = i - 24;
                    this.mv[i, 1] = 0;
                }

            }
        }
        public override string Get() { return " R"; }

        public override int[,] Mv(int[] s)
        {
            int[,] r = new int[this.mv.Length, 2];
            for (int i = 0; i < this.mv.Length; i++)
            {
                r[i, 0] = this.mv[i, 0];
                r[i, 1] = this.mv[i, 1];
            }
            return r;
        }
        public override int[,] Att(int[] s)
        { return this.Mv(s); }
    }
}
