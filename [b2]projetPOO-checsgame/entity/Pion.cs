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
        public override List<int[]> Att(int[] s)
        {
            List<int[]> att = new List<int[]>();
            if (this.color) { att.Add(new int[] { (1 + s[0]), (1 + s[1]) }); }
            else            { att.Add(new int[] { (-1 + s[0]), (1 + s[1]) }); }
            att.Add(new int[] { (1 + s[0]), (-1 + s[1]) });
            if (this.color) { att.Add(new int[] { (1 + s[0]), (-1 + s[1]) }); }
            else            { att.Add(new int[] { (-1 + s[0]), (-1 + s[1]) }); }

            return att;
        }
        public override string Get()
        { return " p"; }
    }
}
