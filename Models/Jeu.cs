using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgMaker.Models.Boutique;
using RpgMaker.Models.Monstres;
using RpgMaker.Models.Objets;

namespace RpgMaker.Models
{
    public class Jeu
    {

        public List<Monstre> listDeMonstres = new List<Monstre>();
        public List<Equipement> listDesEquipements = new List<Equipement>();

        ///<Summary>
        ///Initialise la list des monstres
        ///</Summary>
        public void RandomList() {

            for (int i = 0; i < 10; i++)
            {
                Monstre monstre = new Monstre();
               int random = new Random().Next(1,7);
              
                switch (random)
                {
                    case 1:
                        monstre = new Gobelin();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 2:
                        monstre = new Gobelin();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 3:
                        monstre = new Gobelin();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 4:
                        monstre = new Loup();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 5:
                        monstre = new Loup();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 6:
                        monstre = new Orc();
                        this.listDeMonstres.Add(monstre);
                        break;
                    default:
                        break;
                }
            }
            

        }

        ///<Summary>
        ///Affiche les monstres et leurs attaques
        ///</Summary>
        public void AfficherMonstre()
        {
            foreach (Monstre m in this.listDeMonstres)
            {
                m.ShowCharacterProfile();
                switch (m)
                {
                    case Gobelin gob:
                        gob.CoupDeMasse();
                        //((Gobelin)m).CoupDeMasse();
                        break;
                    case Loup loup:
                        loup.Morsure();
                        loup.Hurlement();
                        //((Loup)m).Morsure();
                        //((Loup)m).Hurlement();
                        break;
                    case Orc orc:
                        orc.CoupDeHache();
                        orc.CriDeGuerre();
                        //((Orc)m).CoupDeHache();
                        //((Orc)m).CriDeGuerre();
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// La boutique pour acheter ou vendre les objets
        /// </summary>
        public void EntrerBoutique()
        {
            Shop.MenuCommand(listDesEquipements);
        }
    }
}
