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
            this.map = new Map();
            this.round = true;
            Console.WriteLine("pour commancer appiyer sur une touche");
            Console.ReadKey();
            this.Round(this.round);
        }
        public void Round(bool round)
        {
            Console.Clear();
            if (round) { new Print("a vous blue", ConsoleColor.Blue); }
            else { new Print("a vous rouge", ConsoleColor.Red); }
            this.map.Print();
            int[] s = map.SelectPion(round);

            //int[,] mv = map.map[s[0], s[1]].Mv(s);
            //int[,] att = map.map[s[0], s[1]].Att(s);
            /*Console.Clear();
            this.map.Print(s, mv);
            this.map.Print();*/

            int[] a = map.Selectact(s,round);
            Console.WriteLine("pion mv");
            //fin r restart
            if (map.Status()==0)//si vivant
            { if (round) { this.Round(false); } else { this.Round(true); } }
            else { this.End(true); }//todo defin win

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
}// dodo :p