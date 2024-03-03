using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models.Characters
{
    public class Pretre : Personnage
    {
        public override int Intelligence { get { return base.Intelligence + 2; } }
        public override int Wisdom { get { return base.Wisdom + 4; } }

        public Pretre()
        {
            Console.WriteLine("Veuillez entrer un nom.");
            Name = Console.ReadLine();
        }

       
    }
}
