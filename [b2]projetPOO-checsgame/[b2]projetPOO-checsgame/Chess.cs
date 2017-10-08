using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame
{
    class Chess
    {
        protected Map map;
        public Chess()
        {
            this.Start();
            Console.WriteLine("Fin de partie");
        }
        private void Start()
        {
            Console.WriteLine("pour commancer appiyer sur une touche");
            this.map = new Map();
            Console.ReadKey();
            this.Round();/*todo boucler p1-2*/
        }
        public void Round()
        {
            Console.Clear();
            this.map.Print();
            int[] s = this.map.Select(true);
            this.map.Action(s);
            Console.ReadKey();
        }
    }
}
