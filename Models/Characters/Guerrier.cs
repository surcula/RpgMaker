using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Characters
{
    public class Guerrier : Personnage
    {

       
        public override int Strength { get { return base.Strength + 3; } set { base.Strength = value; } }
        public override int Endurance { get { return base.Endurance + 3; } set { base.Endurance = value; } }


        public Guerrier()
        {
            Console.WriteLine("Veuillez entrer un nom.");
            Name = Console.ReadLine();
        }

    }
}
