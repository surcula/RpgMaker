using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Characters
{
    internal class Mage : Personnage
    {
        public override int Intelligence { get { return _intelligence + 4; } }
        public override int Sagesse { get { return _sagesse + 2; } }


    }
}
