using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b2_projetPOO_checsgame.entity
{
    class King : Entity
    {
        public King(bool color) : base(color) { }
        public override string Get() { return " k"; }

        public override bool isk()
        { return true; }
    }
}
