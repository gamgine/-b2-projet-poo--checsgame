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
        public Entity[,] map = new Entity[8, 8];//x,y
        public Map()
        {
            this.map[0, 0] = new Rook(true);
            this.map[0, 1] = new Knight(true);
            this.map[0, 2] = new Bishop(true);
            this.map[0, 3] = new King(true);
            this.map[0, 7] = new Rook(true);
            this.map[0, 6] = new Knight(true);
            this.map[0, 5] = new Bishop(true);
            this.map[0, 4] = new Queen(true);
            for (int i = 0; i < 8; i++)
            {
                this.map[1, i] = new Pion(true);
                this.map[6, i] = new Pion(false);
			}
            this.map[7, 0] = new Rook(false);
            this.map[7, 1] = new Knight(false);
            this.map[7, 2] = new Bishop(false);
            this.map[7, 4] = new King(false);
            this.map[7, 7] = new Rook(false);
            this.map[7, 6] = new Knight(false);
            this.map[7, 5] = new Bishop(false);
            this.map[7, 3] = new Queen(false);
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
        //public void Print(int[] act, int[,] mv, int[,] att)//todo print2
        public void Print(int[] act, int[,] mv)//todo bug double
        {
            Console.Clear();
            Console.WriteLine("  a b c d e f g h");
            for (int x = 0; x < 8; x++)
            {
                Console.Write((x + 1));
                for (int y = 0; y < 8; y++)
                {
                    bool bact = false, bmv = false, batt = false;
                    if (act[0] == x && act[1] == y) { bact = true; }
                    else
                    {
                        /*for (int i = 0; i < mv.Length; i++)
							{
                            for (int i2 = 0; i2 < mv.Length; i2++)
                            { if (mv[i, 0] == x && mv[i, 1] == y) { bmv = true; } }
							}
							/*for (int i = 0; i < att.Length; i++)
							{
                            for (int i2 = 0; i2 < att.Length; i2++)
                            { if (att[i, 0] == x && att[i, 1] == y) { bmv = true; } }
						}*/
					}
                    if (this.map[x, y] == null)
                    {
                        if (bmv) { new Print(" -", ConsoleColor.White, ConsoleColor.Green); }
                        else if (batt) { new Print(" -", ConsoleColor.White, ConsoleColor.Yellow); }
                        else { Console.Write(" -"); }
					}
                    else
                    {
                        if (map[x, y].GetColor())
                        {
							new Print(map[x, y].Get(), ConsoleColor.Blue);
							// string  . color . bg color
                            if (bact) { new Print(map[x, y].Get(), ConsoleColor.Black, ConsoleColor.White); }
                            else if (bmv) { new Print(map[x, y].Get(), ConsoleColor.White, ConsoleColor.Green); }
                            else if (batt) { new Print(map[x, y].Get(), ConsoleColor.White, ConsoleColor.Yellow); }
                            else { new Print(map[x, y].Get(), ConsoleColor.Blue); }
						}
                        else
                        { new Print(map[x, y].Get(), ConsoleColor.Red); }
					}
				}
                Console.WriteLine(" " + (x + 1));
			}
            Console.WriteLine("  a b c d e f g h");
		}
        public int[] Select()
        {
            int selectionx = 0, selectiony = 0;
            Console.WriteLine("utiliser les fleches pour vous deplacer et entre pour selectioner");
            Console.Write("position actuel : ");
            Console.WriteLine((selectionx + 1) + " , " + (char)(selectiony + 65));
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key != ConsoleKey.Enter)
                {
                    switch (key)
                    {
                        case ConsoleKey.RightArrow: if (selectiony < 7) { selectiony++; } break;
                        case ConsoleKey.LeftArrow: if (selectiony > 0) { selectiony--; } break;
                        case ConsoleKey.UpArrow: if (selectionx > 0) { selectionx--; } break;
                        case ConsoleKey.DownArrow: if (selectionx < 7) { selectionx++; } break;
                        default:
						Console.WriteLine();
						Console.WriteLine("utiliser les fleches our vous deplacer et entrer pour confirmer votre selection");
                        break;
					}
                    Console.Write((int)(selectionx + 1) + " , " + (char)(selectiony + 65));
				}
                else { break; }
			}
            Console.WriteLine();
            int[] r = { selectionx, selectiony };
            return r;
		}
        public int[] SelectPion(bool round)
        {
            int[] s = {0,0};
            while(true)
            {
                s = this.Select();//todo bug 2a = 2b ; 2b = 2b
                if (this.map[s[0], s[1]] != null)
                {
                    if (this.map[s[0], s[1]].GetColor() == round)
                    {
                        Console.Write("pion selectioner : ");
                        Console.WriteLine((s[0] + 1) + " , " + (char)(s[1] + 65));
                        break;
					}
                    else { Console.WriteLine("ce pion ne vous appartien pas selectionez en un autre"); }
				}
                else { Console.WriteLine("la case est vide selectionez un pion"); }
			}
            return s;
		}
        public int[] Selectact(int[] sel,bool round)
        {
            int[] s = new int[1];
            List < int[] > mv = this.map[sel[0], sel[1]].Mv(sel);//liste mv [n,x/y]
            while (true)
            {
                bool ok=true;
                s = this.Select();//selection mv
                for (int i = 0; i < (mv.Count-1); i++)//-- s is mv
                {
                    //if ( s[0]==mv[i,0]&&s[1]==mv[i,1] ) { ok = true; }//todo debug comparateur
                    if (true) { ok = true; }
				}
                if (ok)//ok mv entity
                {
                    Console.WriteLine("mv");
                    this.Mv(sel, s);
                    break;
				}
                else { Console.WriteLine("vous ne pouvez pas faire ca"); }
			}
            return s;
		}
        private void Mv(int[] e,int []d)
        {
            this.map[d[0], d[1]] = this.map[e[0], e[0]];
            this.map[e[0], e[0]] = null;
		}
        public int Status()
        {
            int b=0,r=0;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    if (this.map[i, i2] != null)
                    {
                        if (this.map[i, i2].Isk())
                        {
                            if(this.map[i, i2].GetColor()) 
                            { b = 1; }
                            else { r = 1; }
						}
					}
				}
			}
            if (b == 1 && r == 1)
            {
                return 0; /*todo null echeque math*/
			}
            return 1;
		}
	}
}