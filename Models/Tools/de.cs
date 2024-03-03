using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Tools
{
    public class De
    {
        private int _quantiteDe;
        private int _typeDe;

        public De(int quantiteDe, int typeDe)
        {
            QuantiteDe = quantiteDe;
            TypeDe = typeDe;
        }

        public int QuantiteDe { get; set; }
        public int TypeDe { get; set; }


        public int Lancer()
        {
            int total = 0;

            for (int i = 0; i < this.QuantiteDe; i++)
            {
                total += new Random().Next(1,this.TypeDe);
            }
            return total;
        }
    }
}
