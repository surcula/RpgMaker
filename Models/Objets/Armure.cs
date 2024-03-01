using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    public class Armure : Equipement
    {
        private int _nbReduction;
        public int NbReduction { get { return _nbReduction; } set { _nbReduction = value; } }

        public Armure(string name, int or, int reduction)
        : base(name, or)
        {
            NbReduction = reduction;
        }

        public void Reduction(int reduction)
        {
            Console.WriteLine($"L'armure : {this._name} réduit les dégats de : {reduction}.");
        }
    }
}
