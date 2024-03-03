using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models.Monstres
{
    public class Monstre : Entite, IDeath
    {


        public override int Strength { get { return _strength; } set { _strength = value; } }
        public override int Endurance { get { return _endurance; } set { _endurance = value; } }
        public override int Health { get; set; }
        public virtual De arme {  get; set; }

        public Monstre() 
        {
            Initialize();    
        }

        /// <summary>
        /// Quand le monstre meurt
        /// </summary>
        public virtual void Death()
        {
            Console.WriteLine($"Le monstre : {this.GetType().Name} est mort !");
        }


        ///<Summary>
        ///Initialise le monstre
        ///</Summary>
        protected override void Initialize()
        {
            Strength = new Random().Next(10, 21);
            Endurance = new Random().Next(10, 21);
            Health = 10 + Carac.ModCarac(Endurance);
        }

        ///<Summary>
        ///Affiche les informations du monstre
        ///</Summary>
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Force : {Strength} ({_strength})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            if(this is IOr monstreOr)
            {
                Console.WriteLine($"Le monstre possède : {monstreOr.GoldQuantity} Po");
            }
        }
    }
}
