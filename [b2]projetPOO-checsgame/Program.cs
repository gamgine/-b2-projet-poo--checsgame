using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame
{
    class Print
    {
        public Print(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.Write(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Print(string s, ConsoleColor c, ConsoleColor back)
        {
            Console.ForegroundColor = c;
            Console.BackgroundColor = back;
            Console.Write(s);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //dodo!!!
            Chess game = new Chess();
            
            Console.WriteLine("voulez vous rejouer? y/n");
            if(Console.ReadKey().Key == ConsoleKey.Y)
            { game = new Chess(); }
        }
    }
}
