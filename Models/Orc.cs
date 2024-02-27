using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Orc : Monstre
    {
        public override int Force { get { return _force + 3; } }
        public override int Endurance { get { return _endurance + 2; } }


        public void CoupDeHache()
        {
            Console.WriteLine("L'orc donne un coup de hache !");
        }

        public void CriDeGuerre()
        {
            Console.WriteLine("L'orc crie : du travail, encore du travail !");
        }

    }
}
