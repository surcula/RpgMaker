using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    class Personnage
    {

        private string _name;
        private int _force;
        private int _endurance;
        private int _intelligence;
        private int _sagesse;

        public string Name { get { return _name; } set { _name = value; } }
        public  virtual int Force { get { return _force; } private set { _force = value; } }
        public virtual int Endurance { get { return _endurance; } private set { _endurance = value; } }
        public virtual int Intelligence { get { return _intelligence; } private set { _intelligence = value; } }
        public virtual int Sagesse { get { return _sagesse; } private set { _sagesse = value; } }

        ///<Summary>
        ///Initialise le personnage
        ///</Summary>
        public void Initialize()
        {
            this.Force = new Random().Next(10, 21);
            this.Endurance = new Random().Next(10, 21);
            this.Intelligence = new Random().Next(10, 21);
            this.Sagesse = new Random().Next(10, 21);
            Console.WriteLine("Choisissez votre nom : ");
            this.Name = Console.ReadLine();
        }

        ///<Summary>
        ///Affiche les informations du personnage
        ///</Summary>
        public void ShowCharacterProfile()
        {

            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Nom : {Name}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");
            
        }

    }
}
