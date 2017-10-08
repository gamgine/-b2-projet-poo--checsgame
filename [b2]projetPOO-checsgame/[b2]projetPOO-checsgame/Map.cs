using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _b2_projetPOO_checsgame.entity;
namespace _b2_projetPOO_checsgame
{
    class Map
    {
        private Entity[,] map = new Entity[8, 8];//x,y
        private int selectionx, selectiony;
        public Map()
        {
            selectionx = selectiony = 0;
            for (int i = 0; i < 8; i++)
            {
                this.map[1, i] = new Pion(true);
                this.map[6, i] = new Pion(false);
            }
        }
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("  a b c d e f g h");
            for (int x = 0; x < 8; x++)
            {
                Console.Write((x + 1));
                for (int y = 0; y < 8; y++)
                {
                    if (this.map[x, y] == null)
                    { Console.Write(" -"); }
                    else
                    {
                        if (map[x, y].GetColor())
                        { new Print(map[x, y].Get(), ConsoleColor.Blue); }
                        else
                        { new Print(map[x, y].Get(), ConsoleColor.Red); }
                    }
                }
                Console.WriteLine(" " + (x + 1));
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public int[] Select(bool playercolor)
        {
            bool selected = false;
            Console.WriteLine("selectioner un pion avec les fleches");
            Console.Write("position actuel : ");
            Console.WriteLine((this.selectionx + 1) + " , " + (char)(this.selectiony + 65));
            while (selected == false)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key != ConsoleKey.Enter)
                {
                    switch (key)
                    {
                        case ConsoleKey.RightArrow:
                            if (this.selectiony < 7) { this.selectiony++; }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (this.selectiony > 0) { this.selectiony--; }
                            break;
                        case ConsoleKey.UpArrow:
                            if (this.selectionx > 0) { this.selectionx--; }
                            break;
                        case ConsoleKey.DownArrow:
                            if (this.selectionx < 7) { this.selectionx++; }
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("utiliser les fleches our vous deplacer et entrer pour confirmer votre selection");
                            break;
                    }
                    Console.Write((this.selectionx + 1) + " , " + (char)(this.selectiony + 65));
                }
                else
                {
                    Console.WriteLine();
                    if (this.map[this.selectionx, this.selectiony] != null)
                    {
                        if(this.map[this.selectionx, this.selectiony].GetColor() == playercolor)
                        {
                            Console.Write("pion selectioner : ");
                            Console.Write((this.selectionx + 1) + " , " + (char)(this.selectiony + 65));
                            selected = true;
                        }
                        else { Console.WriteLine("ce pion ne vous appartien pas selectionez en un autre"); }
                    }
                    else { Console.WriteLine("la case est vide selectionez un pion"); }
                }
            }
            Console.WriteLine();
            int[] r = {this.selectionx,this.selectiony};
            return r;
        }
        public void Action(int[] sel)
        {

        }
        private void Mv(int[] e,int []d)
        {
            this.map[d[0], d[1]] = this.map[e[0], e[0]];
            this.map[e[0], e[0]] = null;
        }
        private void Del(int[] e)
        { this.map[e[0], e[0]] = null; }
    }
}
/*todo start 1740*/