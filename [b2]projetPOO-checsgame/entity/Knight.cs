using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Knight : Entity
    {
        private int[,] mv =new int[8,2];
        public Knight(bool color) : base(color)
        {
            /*for (int i = 0; i < 32; i++)
            {
                if (i < 8)
                {
                    this.mv[i, 0] = -i;
                    this.mv[i, 1] = -i;
                }
                if (i > 8 && i < 16)
                {
                    this.mv[i, 0] = (i - 8);
                    this.mv[i, 1] = -(i - 8);
                }

                if (i > 16 && i < 24)
                {
                    this.mv[i, 0] = (i - 16);
                    this.mv[i, 1] = (i - 16);
                }
                if (i > 24)
                {
                    this.mv[i, 0] = -(i - 24);
                    this.mv[i, 1] = (i - 24);
                }

            }*/
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
