using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    internal class Armure : Equipement
    {
        private int _nbReduction;
        public int NbReduction { get { return _nbReduction; } set { _nbReduction = value; } }

        public void Reduction(int reduction)
        {
            Console.WriteLine($"L'armure : {this._name} réduit les dégats de : {reduction}.");
        }
    }
}
