using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class King : Entity
    {
        public King(bool color) : base(color) { }
        public override string Get() { return " k"; }

        public override int[,] Mv(int[] s)
        {
            int[,] mv = { { 1, 1 }, { 0, 1 }, { 1, 0 }, { -1, -1 }, { 0, -1 }, { -1, 0 }, { -1, 1 }, { 1, -1 } };
            for (int i = 0; i < mv.Length; i++)
            {
                mv[i, 0] += s[0];
                mv[i, 1] += s[1];
            }
            return mv;
        }
        public override int[,] Att(int[] s)
        { return this.Mv(s); }
        public override bool isk()
        { return true; }
    }
}
