using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    internal abstract class Equipement : IOr
    {
        protected string _name;
        protected int _goldQuantity;

        public string Name { get { return _name; } set { _name = value; } }
        public int GoldQuantity { get { return _goldQuantity; } set { _goldQuantity = value; } }
    }
}
