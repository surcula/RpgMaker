using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models
{
    internal class Monstre : Entite
    {
        public override int Force { get { return _force; } protected set { _force = value; } }
        public override int Endurance { get { return _endurance; } protected set { _endurance = value;} }


        ///<Summary>
        ///Initialise le monstre
        ///</Summary>
        public override void Initialize()
        {
            this.Force = new Random().Next(10, 21);
            this.Endurance = new Random().Next(10, 21);
        }

        ///<Summary>
        ///Affiche les informations du monstre
        ///</Summary>
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
        }
    }
}
