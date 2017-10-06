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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chess game = new Chess();
            Console.WriteLine("Fin de partie");
            Console.ReadKey();
        }
    }
}
