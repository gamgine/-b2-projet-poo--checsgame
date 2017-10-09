using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _b2_projetPOO_checsgame
{
    class Entity
    {
        protected bool color;
        public Entity(bool color)
        { this.color = color; }
        public virtual string Get()
        { return " *"; }
        public bool GetColor()
        { return this.color; }

        public virtual int[,] Mv(int[]s)
        {   return new int [0,0];   }
        public virtual int[,] Att(int[]s)
        {
            int[,] mv = new int[0, 0];
            return mv;
        }
        public virtual bool isk()
        { return false; }
    }//todo definir tous elements et verif bugs
}

