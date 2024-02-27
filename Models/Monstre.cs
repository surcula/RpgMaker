using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models
{
    internal class Monstre
    {
        
        private int _force;
        private int _endurance;

        public virtual int Force { get { return _force; } private set { _force = value; } }
        public virtual int Endurance { get { return _endurance; } private set { _endurance = value; } }


        ///<Summary>
        ///Initialise le monstre
        ///</Summary>
        public void Initialize()
        {
            this.Force = new Random().Next(10, 21);
            this.Endurance = new Random().Next(10, 21);
        }

        ///<Summary>
        ///Affiche les informations du monstre
        ///</Summary>
        public void ShowCharacterProfile()
        {

            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
        }
    }
}
