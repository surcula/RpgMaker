using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models.Monstres
{
    internal class Monstre : Entite, IDeath
    {



        public override int Force { get { return _force; } protected set { _force = value; } }
        public override int Endurance { get { return _endurance; } protected set { _endurance = value; } }

        public virtual void Death()
        {
            Console.WriteLine($"Le monstre : {this.GetType().Name} est mort !");
        }


        ///<Summary>
        ///Initialise le monstre
        ///</Summary>
        public override void Initialize()
        {
            Force = new Random().Next(10, 21);
            Endurance = new Random().Next(10, 21);
        }

        ///<Summary>
        ///Affiche les informations du monstre
        ///</Summary>
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
        }
    }
}
