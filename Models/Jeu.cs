using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgMaker.Models.Boutique;
using RpgMaker.Models.Characters;
using RpgMaker.Models.Game;
using RpgMaker.Models.Monstres;
using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;

namespace RpgMaker.Models
{
    public class Jeu
    {

        public List<Monstre> listDeMonstres = new List<Monstre>();
        public List<Equipement> listDesEquipements = new List<Equipement>();
        Personnage personnage = new Personnage{};


        public Jeu() 
        { 
            InitEquipement();
            InitPersonnage();
            afficherPersonnage();
            EntrerBoutique();
            RandomListMonstre();
            Combat();
        }

        private void InitPersonnage()
        {
            Console.Clear();
            int choiceUser = 0;
            while (choiceUser < 1 || choiceUser > 3)
            {
                Console.WriteLine("Quelle classe voulez-vous jouer ? ");
                Console.WriteLine("1. Guerrier");
                Console.WriteLine("2. Mage");
                Console.WriteLine("3. Prêtre");
                choiceUser = int.Parse(Console.ReadLine());

            }
            switch (choiceUser)
            {
                case 1:
                    personnage = new Guerrier();
                    break;
                case 2:
                    personnage = new Mage();
                    break;
                case 3:
                    personnage = new Pretre();
                    break;
                default:
                    break;
            }
        }
        private void InitEquipement()
        {
            Arme arme = new Arme("Epee Courte", 15, new De(1, 6));
            Arme arme2 = new Arme("Epee Longue", 25, new De(1, 8));
            Arme arme3 = new Arme("baton", 10, new De(1, 4));
            Armure armure = new Armure("Armure de cuir", 20, 2);
            Armure armure2 = new Armure("Armure de plaque", 50, 5);
            Consommable consommable = new Consommable("potion de vie", 20);
            listDesEquipements.Add(arme);
            listDesEquipements.Add(arme2);
            listDesEquipements.Add(arme3);
            listDesEquipements.Add(armure);
            listDesEquipements.Add(armure2);
            listDesEquipements.Add(consommable);
        }



        ///<Summary>
        ///Initialise la list des monstres
        ///</Summary>
        public void RandomListMonstre() {

            for (int i = 0; i < 10; i++)
            {
                Monstre monstre = new Monstre();
               int random = new Random().Next(1,7);
              
                switch (random)
                {
                    case 1:
                    case 2:
                    case 3:
                        monstre = new Gobelin();
                        int randomNbItem = new Random().Next(0, 3);

                        for (int j = 0; j < randomNbItem; j++)
                        {
                            int randomLoot = new Random().Next(0, listDesEquipements.Count());
                            ((Gobelin)monstre).inventaire.Add(listDesEquipements[randomLoot]);
                        }
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 4:                        
                    case 5:
                        monstre = new Loup();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 6:
                        monstre = new Orc();
                        int randomNbItem2 = new Random().Next(0, 3);

                        for (int j = 0; j < randomNbItem2; j++)
                        {
                            int randomLoot = new Random().Next(0, listDesEquipements.Count());
                            ((Orc)monstre).inventaire.Add(listDesEquipements[randomLoot]);
                        }
                        this.listDeMonstres.Add(monstre);                                              
                        break;
                    default:
                        break;
                }
            }
            

        }

        public void afficherPersonnage()
        {
            Console.Clear();
            personnage.ShowCharacterProfile();
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
            
            Shop.MenuCommand(listDesEquipements,this.personnage);
        }

        public void Combat()
        {
            Battle.InitBatttle(personnage,listDeMonstres, listDesEquipements);
        }

       
    }
}
