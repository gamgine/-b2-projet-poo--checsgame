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
        private Entity[,] map = new Entity[8, 8];
        private int[,] selection = new int[1, 1];
        public Map()
        {
            for (int i = 0; i < 8; i++)
            {
                this.map[1, i] = new Pion(true);
                this.map[6, i] = new Pion(false);
            }
        }
        public void Print()
        { /*TODO map */
            Console.Clear();
            Console.WriteLine("  a b c d e f g i");
            for (int i = 0; i < 8; i++)
            {
                Console.Write((i + 1));
                for (int i2 = 0; i2 < 8; i2++)
                {
                    if (this.map[i, i2] == null)
                    { Console.Write(" -"); }
                    else { map[i, i2].Print(); }
                }
                Console.WriteLine(" " + (i + 1));
            }
            Console.WriteLine("  a b c d e f g i");
        }
        public void select()
        {
            bool selected = false;
            while (selected == false)
            {
                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Write("lesft");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write("Right");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Write("up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write("down");
                        break;
                    case ConsoleKey.Enter:
                        Console.Write("pion selectioner");
                        selected = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("utiliser les fleches our vous deplacer et entrer pour confirmer votre selection");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
