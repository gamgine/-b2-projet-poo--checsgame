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
        { this.color = color; this.mv = new int[0,0]; }
        public virtual string Get()
        { return " *"; }
        public bool GetColor()
        { return this.color; }
        public List<int[]> Mv(int[]s)
        {
            List<int[]> mvl = new List<int[]>();
            for (int i = 0; i < this.mv.Length; i++)
            {
                int[] m = { this.mv[i, 0] + s[0] , this.mv[i, 1] + s[1] };
                if ((m[0]<=0 && m[0] > 8)&& (m[1] <= 0 && m[1] > 8))
                { mvl.Add(m); }
            }
            return mvl;
        }
        public virtual List<int[]> Att(int[]s)
        { return this.Mv(s); }
        public virtual bool Isk()
        { return false; }
    }//todo definir tous elements et verif bugs
}

