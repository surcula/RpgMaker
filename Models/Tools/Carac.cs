using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Tools
{
    public static class Carac
    {
        /// <summary>
        /// Calcule le modificateur d'une caractéristique
        /// </summary>
        /// <param name="carac"></param>
        /// <returns></returns>
        public static int ModCarac(int carac)
        {
            if (carac < 10) { return -1; }
            int modificateur;
            modificateur = (carac - 10) / 2;
            return modificateur;
        }
    }
}
