using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    public abstract class Entite
    {
        protected int _strength;
        protected int _endurance;
        protected int _health;

        /// <summary>
        /// La force de l'entité
        /// </summary>
        public abstract int Strength { get; set; }

        /// <summary>
        /// L'endurance de l'entité
        /// </summary>
        public abstract int Endurance { get; set; }
        /// <summary>
        /// La santé de l'entité
        /// </summary>
        public abstract int Health { get ; set ; }

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
