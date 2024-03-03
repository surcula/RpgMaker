using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RpgMaker.Models.Monstres
{
    public class Gobelin : Monstre, IInventaire, IOr

    {
        
        protected int _goldQuantity;
        public List<Equipement> inventaire { get; set; } = new List<Equipement>();
        public override De arme { get => base.arme; set => base.arme = value; }

        /// <summary>
        /// L'or que le gobelin va donner a sa mort
        /// </summary>
        public int GoldQuantity { get { return _goldQuantity; } set { _goldQuantity = value; } }
        public override int Strength { get { return base.Strength - 1; } }
        public Gobelin()
        {
            Initialize();
        }

        protected override void Initialize()
        {
            base.Initialize();
            arme = new De(1,4);
            this.GoldQuantity = new Random().Next(0, 10);
        }



        public void CoupDeMasse()
        {
            Console.WriteLine("Le gobelin donne un coup de masse !");
        }

        public override void Death()
        {
            base.Death();
            Console.WriteLine($"Vous avez gagné : {this.GoldQuantity} Po");

            if (this.inventaire.Count() > 0)
            {
                foreach (Equipement item in this.inventaire)
                {
                    Console.WriteLine($"Vous avez gagné : {item.Name} .");
                }
            }

        }

        public void AttribuerObjet(List<Equipement> listGlobal)
        {

            Random r = new Random();
            int nbLoot = r.Next(0, 3);
            int compteur = 0;
            for (int i = 0; i < nbLoot; i++)
            {
                int flag = r.Next(0, listGlobal.Count());

                foreach (Equipement item in listGlobal)
                {
                    if (flag == compteur)
                    {
                        this.inventaire.Add(item);
                    }
                    compteur++;
                }
            }
        }
    }
}
