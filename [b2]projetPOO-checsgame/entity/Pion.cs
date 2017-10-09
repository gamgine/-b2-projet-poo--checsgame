using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class Pion : Entity
    {
        private int[,] mvlist = new int[1, 2];
        public Pion(bool color) : base(color){}
        public override string Get()
        { return " p"; }
        public override int[,] Mv(int[] s)
        {
            int[,]mv= new int[1,2];
            int m;
            mv[0, 1] = s[0];

            //if(this.color) { m = s[1]+1; }//desc blue
            //else { m = s[1]-1; }//as red
            m = s[1];
            if (m < 0 && m > 8) { mv[0, 0] = m; }
            return mv;
        }
        public override int[,] Att(int[] s)
        {
            int[,] mv=new int[2,2];
            mv[0, 1] = 1;
            mv[0, 0] = 1;
            mv[1, 1] = -1;
            mv[1, 0] = 1;
            return mv;
        }
    }
}
