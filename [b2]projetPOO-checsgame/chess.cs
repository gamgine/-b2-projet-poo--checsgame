using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame
{
    class Chess
    {
        protected Player p1, p2;
        protected Map map;
        public Chess()
        {
            this.p1 = new Player("p1", true);
            this.p2 = new Player("p2", false);
            this.Start();
        }
        public void Start()
        {
            Console.WriteLine("pour commancer appiyer sur une touche");
            this.map = new Map();
            Console.ReadKey();
            this.Round();
        }
        public void Round()
        {
            Console.Clear();
            this.map.Print();
            Console.WriteLine("selectioner un pion avec les fleches");
            this.map.select();
            Console.ReadKey();
        }
    }
}
