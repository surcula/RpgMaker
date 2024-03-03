using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    public interface IInventaire
    {
        /// <summary>
        /// L'inventaire du personnage ou du monstre qui lâche un objet
        /// </summary>
        List<Equipement> inventaire { get; set; }
    }
}
