using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal abstract class Entite
    {
        protected int _force;
        protected int _endurance;
        public abstract int Force { get; protected set; }
        public abstract int Endurance { get; protected set; }

        ///<Summary>
        ///Initialise le personnage
        ///</Summary>
        public abstract void Initialize();

        ///<Summary>
        ///Affiche les informations du personnage
        ///</Summary>
        public abstract void ShowCharacterProfile();
    }
}
