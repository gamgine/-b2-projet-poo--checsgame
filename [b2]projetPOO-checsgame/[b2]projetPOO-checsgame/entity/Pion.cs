using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Pion : Entity
    {
        public Pion(bool color) : base(color)
        { }
        public override string Get()
        { return " p"; }
        public override int[,] Mv(int[,] s)
        {
            int[,]mv= new int[1,1];
            mv[0, 0] = s[0,0];
            if(this.color)
            { mv[0, 1] = s[0, 1]-1; }
            else
            { mv[0, 1] = s[0, 1]+1; }
            return mv;
        }
        public override int[,] Att(int[,] s)
        {
            int[,] mv = new int[1, 1];
            return mv;
        }
    }
}
