using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame
{
    class Chess
    {
        private Map map;
        private bool round;
        public Chess()
        {
            this.Start();
        }
        private void Start()
        {
            Console.WriteLine("pour commancer appiyer sur une touche");
            this.map = new Map();
            round = true;
            Console.ReadKey();
            this.Round(round);/*todo boucler p1-2*/
        }
        public void Round(bool round)
        {
            Console.Clear();
            this.map.Print();
            int[] s = this.map.Select(round);
            this.map.Action(s);
            Console.ReadKey();
            End(true);
        }
        private void End(bool winer)
        {
            Console.WriteLine("Fin de partie");
            if (winer)
            { new Print("l equipe bleu remporte la partie", ConsoleColor.Blue); }
            else
            { new Print("l equipe rouge remporte la partie", ConsoleColor.Red); }
            Console.WriteLine();
        }
    }
}
