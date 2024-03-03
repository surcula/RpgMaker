using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Characters
{
    public class Mage : Personnage
    {
        public override int Intelligence { get { return base.Intelligence + 4; } }
        public override int Wisdom { get { return base.Wisdom + 2; } }

        
        public Mage()
        {
            Console.WriteLine("Veuillez entrer un nom.");
            Name = Console.ReadLine();
        }
    }
}
