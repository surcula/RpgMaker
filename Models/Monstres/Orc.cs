using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Monstres
{
    public class Orc : Monstre, IInventaire, IOr, IDeath
    {

        protected int _goldQuantity;
        public int GoldQuantity { get { return _goldQuantity; } set { _goldQuantity = value; } }
        public List<Equipement> inventaire { get; set; } = new List<Equipement>();
        public override int Strength { get { return base.Strength + 3; } }
        public override int Endurance { get { return base.Endurance + 2; } }
        public override De arme { get => base.arme; set => base.arme = value; }

        public Orc()
        {
            Initialize();
        }

        protected override void Initialize()
        {
            base.Initialize();
            arme = new De(1,8);
            this.GoldQuantity = new Random().Next(0, 10);
        }

        public void CoupDeHache()
        {
            Console.WriteLine("L'orc donne un coup de hache !");
        }

        public void CriDeGuerre()
        {
            Console.WriteLine("L'orc crie : du travail, encore du travail !");
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
