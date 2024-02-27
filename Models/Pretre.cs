using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models
{
    internal class Pretre : Personnage
    {
        public override int Intelligence { get { return base.Intelligence + 2; } }
        public override int Sagesse { get { return base.Sagesse + 4; } }

        
    }
}
