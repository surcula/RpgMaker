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
        public override int Intelligence { get { return _intelligence + 2; } }
        public override int Sagesse { get { return _sagesse + 4; } }

        
    }
}
