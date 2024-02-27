using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Mage : Personnage
    {
        public override int Intelligence { get { return base.Intelligence + 4; } }
        public override int Sagesse { get { return base.Sagesse + 2; } }

        
    }
}
