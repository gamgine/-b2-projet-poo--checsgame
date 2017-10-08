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
        private bool round,end;
        public Chess()
        {
            this.Start();
        }
        private void Start()
        {
            this.map = new Map();
            this.round = true;
            this.end = false;
            Console.WriteLine("pour commancer appiyer sur une touche");
            Console.ReadKey();
            while (true)
            {
                this.Round(this.round);
                //todo finir round
                if (this.end) { break; }
                if (this.round) { this.round = false; }
                else { this.round = true; }
            }
            End(true);
            Console.ReadKey();
        }
        public void Round(bool round)
        {
            Console.Clear();
            this.map.Print();
            int[] s = this.map.Select(round);
            this.map.Action(s);
            Console.ReadKey();
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
