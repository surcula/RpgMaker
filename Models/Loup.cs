using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Loup : Monstre
    {
        public override int Force { get { return base.Force + 2; } }
        public override int Endurance { get { return base.Endurance + 1; } }

        public void Morsure()
        {
            Console.WriteLine("Le loup mord !");
        }

        public void Hurlement()
        {
            Console.WriteLine("Le loup hurle !");
        }

    }
}
