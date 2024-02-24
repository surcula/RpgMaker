using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Mage
    {
        private string _name;
        private int _force;
        private int _endurance;
        private int _intelligence;
        private int _sagesse;

        public string Name { get { return _name; } set { _name = value; } }
        public int Force { get { return _force; } private set { _force = value; } }
        public int Endurance { get { return _endurance; } private set { _endurance = value; } }
        public int Intelligence { get { return _intelligence + 4; } private set { _intelligence = value; } }
        public int Sagesse { get { return _sagesse + 2; } private set { _sagesse = value; } }

        public void Initialize()
        {
            this.Force = new Random().Next(10, 21);
            this.Endurance = new Random().Next(10, 21);
            this.Intelligence = new Random().Next(10, 21);
            this.Sagesse = new Random().Next(10, 21);
        }
    }
}
