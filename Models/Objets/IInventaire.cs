using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Objets
{
    public interface IInventaire
    {
        List<Equipement> inventaire { get; set; }
    }
}
