using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    public class Arme : Equipement
    {
        public Arme(string name, int or, De deArme)
        :base(name,or)
        {
            DeArme = deArme;
        }

        public De DeArme { get; set; }
        public void Attaque() {

            int total = 0;
            for (int i = 0; i < this.DeArme.QuantiteDe; i++)
            {
                total += new Random().Next(1,this.DeArme.TypeDe + 1);
            }

            Console.WriteLine($" l'arme : {this.Name} fait {total} dégats.");
        }
    }
}
