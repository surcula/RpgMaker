using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Guerrier : Personnage
    {

        
        public override int Force { get { return _force + 3; } }
        public override int Endurance { get { return _endurance = + 3; } }

        
    }
}
