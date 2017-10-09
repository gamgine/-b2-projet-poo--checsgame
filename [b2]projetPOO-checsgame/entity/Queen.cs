using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Queen : Entity
    {
        private int[,] mv;
        public Queen(bool color) : base(color)
        {/*
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
                if (i > 24 && i < 32)
                {
                    this.mv[i, 0] = i - 24;
                    this.mv[i, 1] = 0;
                }
                //
                if (i > 32 && i < 40)
                {
                    this.mv[i, 0] = -(i - 32);
                    this.mv[i, 1] = -(i - 32);
                }
                if (i > 40 && i < 48)
                {
                    this.mv[i, 0] = (i - 40);
                    this.mv[i, 1] = -(i - 40);
                }

                if (i > 48 && i < 56)
                {
                    this.mv[i, 0] = (i - 48);
                    this.mv[i, 1] = (i - 48);
                }
                if (i > 56)
                {
                    this.mv[i, 0] = -(i - 56);
                    this.mv[i, 1] = (i - 56);
                }
            }*/
        }
        public override string Get() { return " Q"; }
    }
}
