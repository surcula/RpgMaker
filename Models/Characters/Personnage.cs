using RpgMaker.Models.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Characters
{
    class Personnage : Entite, IInventaire, IOr
    {

        private string _name;
        protected int _intelligence;
        protected int _sagesse;
        protected int _goldQuantity;
        public int GoldQuantity { get { return _goldQuantity; } set { _goldQuantity = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public virtual int Intelligence { get { return _intelligence; } protected set { _intelligence = value; } }
        public virtual int Sagesse { get { return _sagesse; } protected set { _sagesse = value; } }
        public override int Force { get { return _force; } protected set { _force = value; } }
        public override int Endurance { get { return _endurance; } protected set { _endurance = value; } }

        public List<Equipement> inventaire { get; set; } = new List<Equipement>();

        ///<Summary>
        ///Initialise le personnage
        ///</Summary>
        public override void Initialize()
        {
            Force = new Random().Next(10, 21);
            Endurance = new Random().Next(10, 21);
            Intelligence = new Random().Next(10, 21);
            Sagesse = new Random().Next(10, 21);
            Console.WriteLine("Choisissez votre nom : ");
            Name = Console.ReadLine();
        }

        ///<Summary>
        ///Affiche les informations du personnage
        ///</Summary>
        public override void ShowCharacterProfile()
        {

            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Nom : {Name}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");

        }

    }
}
