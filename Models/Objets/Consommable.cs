using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    internal class Consommable : Equipement
    {
        public void Effet() {
            int total = 0;
            for (int i = 0; i < 2; i++)
            {
                total += new Random().Next(1,  5);
            }

            Console.WriteLine($" la potion : {this.Name} rend {total} PV.");
        }
    }
}
