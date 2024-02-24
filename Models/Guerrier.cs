using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Guerrier
    {

        private string _name;
        private int _force;
        private int _endurance;
        private int _intelligence;
        private int _sagesse;

        public string Name { get { return _name; } set { _name = value; } }
        public int Force { get { return _force + 3; } private set { _force = value; } }
        public int Endurance { get { return _endurance + 3; } private set { _endurance = value; } }
        public int Intelligence { get { return _intelligence; } private set { _intelligence = value; } }
        public int Sagesse { get { return _sagesse; } private set { _sagesse = value; } }

       ///<Summary>
       ///Initialise le guerrier
       ///</Summary>
        public void Initialize()
        {
            this.Force =  new Random().Next(10,21);
            this.Endurance = new Random().Next(10, 21);
            this.Intelligence = new Random().Next(10, 21);
            this.Sagesse = new Random().Next(10, 21);
        }

    }
}
