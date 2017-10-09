using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Bishop : Entity
    {
        private int[,] mv = new int[32, 2];
        public Bishop(bool color) : base(color)
        {
            for (int i = 0; i < 8; i++)
            {
                this.mv[i, 0] = i;
                this.mv[i, 1] = i;
            }
            for (int i = 0; i < 8; i++)
            {
                this.mv[i+8, 0] = -i;
                this.mv[i+8, 1] = -i;
            }
            for (int i = 0; i < 8; i++)
            {
                this.mv[i+16, 0] = -i;
                this.mv[i+16, 1] = i;
            }
            for (int i = 0; i < 8; i++)
            {
                this.mv[i + 24, 0] = i;
                this.mv[i + 24, 1] = -i;
            }

        }
        public override string Get() { return " B"; }
    }
}
