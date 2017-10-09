using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _b2_projetPOO_checsgame
{
    class Entity
    {
        private int[,] mv;
        protected bool color;
        public Entity(bool color)
        { this.color = color; }
        public virtual string Get()
        { return " *"; }
        public bool GetColor()
        { return this.color; }

        public int[,] Mv(int[]s)
        {
            int ml = 0;
            int[,] r = { };
            for (int i = 0; i < this.mv.Length; i++)
            {
                int p = this.mv[i, 0] + s[0];
                int p2 = this.mv[i, 1] + s[1];
                if ((p < 8 && p > 0) && (p2 < 8 && p2 > 0))
                {
                    r[ml, 0] = p;
                    r[ml, 1] = p2;
                    ml++;
                }
            }
            return r;
        }
        public virtual int[,] Att(int[]s)
        { return this.Mv(s); }
        public virtual bool isk()
        { return false; }
    }//todo definir tous elements et verif bugs
}

