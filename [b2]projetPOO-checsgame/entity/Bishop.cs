using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Bishop : Entity
    {
        private int[,] mvlist = new int[32, 2];
        public Bishop(bool color) : base(color)
        {
            for (int i = 0; i < 16; i++)
            {
                this.mvlist[i, 0] = 0;
                if (i < 8) { this.mvlist[i, 1] = -i; }
                else { this.mvlist[i, 1] = i; }
            }
            for (int i = 0; i < 16; i++)
            {
                this.mvlist[i, 0] = 1;
                if (i < 8) { this.mvlist[i, 0] = -i; }
                else { this.mvlist[i, 0] = i; }
            }

        }
        public override string Get() { return " B"; }

        public override int[,] Mv(int[] s)
        {
            int[,] mv = this.mvlist;
            int[,] mvl = { };
            for (int i = 0; i < mv.Length; i++)
            {
                mv[i, 1] += s[1];
                mv[1, 0] += s[0];
                if (mv[i, 0] < 8 && mv[i, 0] > 0 && mv[i, 1] < 8 && mv[i, 1] > 0)//si dans pl
                {
                    mvl[mvlist.Length + 1, 0] = mv[i, 0];
                    mvl[mvlist.Length + 1, 0] = mv[i, 1];
                }
            }
            return mvl;
        }
        public override int[,] Att(int[] s)
        { return this.Mv(s); }
    }
}
