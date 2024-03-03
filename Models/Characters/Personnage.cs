using RpgMaker.Models.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgMaker.Models.Tools;
using RpgMaker.Models.Monstres;

namespace RpgMaker.Models.Characters
{
    public class Personnage : Entite, IInventaire, IOr
    {

        private string _name;
        protected int _intelligence;
        protected int _wisdom;
        protected int _goldQuantity;

        public Personnage()
        {
            Initialize();
        }

        /// <summary>
        /// L'or du personnage
        /// </summary>
        public int GoldQuantity { get { return _goldQuantity; } set { _goldQuantity = value; } }
        /// <summary>
        /// Le nom du personnage
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        /// <summary>
        /// L'intelligence du personnage
        /// </summary>
        public virtual int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        /// <summary>
        /// La sagesse du personnage
        /// </summary>
        public virtual int Wisdom { get { return _wisdom; } set { _wisdom = value; } }
        public override int Strength { get { return _strength; } set { _strength = value; } }
        public override int Endurance { get { return _endurance; } set { _endurance = value; } }

        public List<Equipement> inventaire { get; set; } = new List<Equipement>();
        public override int Health { get; set; }

        ///<Summary>
        ///Initialise le personnage
        ///</Summary>
        protected override void Initialize()
        {
            Console.Clear();
            Strength = new Random().Next(10, 21);
            Endurance = new Random().Next(10, 21);
            Intelligence = new Random().Next(10, 21);
            Wisdom = new Random().Next(10, 21);
            GoldQuantity = 100;
            Health = 10 + Carac.ModCarac(this.Endurance);


        }

        ///<Summary>
        ///Affiche les informations du personnage
        ///</Summary>
        public override void ShowCharacterProfile()
        {
            Console.WriteLine("Voici votre Personnage : ");
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Nom : {Name}");
            Console.WriteLine($"Force : {Strength} ({_strength})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Wisdom} ({_wisdom})");
            Console.WriteLine($"Gold : {GoldQuantity}");
            Console.WriteLine($"Point de vie : ({Health})");
            Console.ReadKey();
        }

    }
}
