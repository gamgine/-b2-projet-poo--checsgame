using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _b2_projetPOO_checsgame
{
    class Entity
    {
        protected bool color;
        public Entity(bool color)
        { this.color = color; }
        public virtual void Print()
        { new Print(" * ", ConsoleColor.Red); }
    }
}
