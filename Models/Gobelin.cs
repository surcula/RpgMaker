using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Gobelin : Monstre
    {
        public override int Force { get { return _force - 1; } }

        public void CoupDeMasse()
        {
            Console.WriteLine("Le gobelin donne un coup de masse !");
        }
    }
}
