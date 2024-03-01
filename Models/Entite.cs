using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    public abstract class Entite
    {
        protected int _force;
        protected int _endurance;
        protected int pv;
        public abstract int Force { get; protected set; }
        public abstract int Endurance { get; protected set; }
        protected int Pv { get => pv; set => pv = value; }

        ///<Summary>
        ///Initialise le personnage
        ///</Summary>
        protected abstract void Initialize();

        ///<Summary>
        ///Affiche les informations du personnage
        ///</Summary>
        public abstract void ShowCharacterProfile();
    }
}
