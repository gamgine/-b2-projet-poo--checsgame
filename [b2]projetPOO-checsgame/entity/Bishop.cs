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
    }
}
