using RpgMaker.Models.Boutique;
using RpgMaker.Models.Characters;
using RpgMaker.Models.Monstres;
using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Game
{
    public class Battle
    {
        private static Arme ArmePlayer { get; set; }
        private static Armure ArmurePlayer { get; set; }
        private static List<Arme> armes { get; set; } = new List<Arme>();
        private static List<Armure> armures { get; set; } = new List<Armure> { };
        private static List<Consommable> consommables { get; set; } = new List<Consommable>();

        /// <summary>
        /// Initialise les listes pour l'utilisation en combat
        /// </summary>
        /// <param name="personnage"></param>
        private static void InitLists(Personnage personnage)
        {
            
            foreach (Equipement item in personnage.inventaire)
            {
                switch (item)
                {
                    case Arme arme:
                        armes.Add(arme);
                        break;
                    case Armure armure:
                        armures.Add(armure);
                        break;
                    case Consommable consommable:
                        consommables.Add(consommable);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Init du combat
        /// </summary>
        /// <param name="personnage"></param>
        /// <param name="listMonstres"></param>
        public static void InitBatttle(Personnage personnage, List<Monstre> listMonstres, List<Equipement> listDesEquipements)
        {
            InitLists(personnage);
            ChoiceArme(personnage);
            ChoiceArmure(personnage);
            BattleHorde(personnage, listMonstres,listDesEquipements);

        }

        /// <summary>
        /// Choix de l'arme pour le combat
        /// </summary>
        /// <param name="personnage"></param>
        private static void ChoiceArme(Personnage personnage)
        {
            int choiceUser = 0;
            Console.Clear();
            Console.WriteLine("Veuillez choisir une arme à utiliser.");
            for (int i = 0; i < armes.Count(); i++)
            {
                Console.WriteLine($"{i}: {armes[i].Name}");
            }

            do
            {
                choiceUser = int.Parse(Console.ReadLine());

            } while (choiceUser < 0 || choiceUser > armes.Count());

            ArmePlayer = armes[choiceUser];

        }
        /// <summary>
        /// Choix de l'armure pour le combat
        /// </summary>
        /// <param name="personnage"></param>
        private static void ChoiceArmure(Personnage personnage)
        {
            int choiceUser = 0;

            Console.Clear();
            Console.WriteLine("Veuillez choisir une armure à utiliser.");
            for (int i = 0; i < armes.Count(); i++)
            {
                Console.WriteLine($"{i}: {armures[i].Name}");
            }

            do
            {
                choiceUser = int.Parse(Console.ReadLine());

            } while (choiceUser < 0 || choiceUser > armures.Count());

            ArmurePlayer = armures[choiceUser];

        }

        /// <summary>
        /// Le combat
        /// </summary>
        /// <param name="personnage"></param>
        /// <param name="listMonstres"></param>
        private static void BattleHorde(Personnage personnage, List<Monstre> listMonstres, List<Equipement> listDesEquipements)
        {
            int compteur = 0;

            while (personnage.Health > 0 && compteur < listMonstres.Count())
            {
                Console.Clear() ;
                Console.WriteLine($"Le combat : {compteur + 1} débute ...... Il vous reste {personnage.Health} point de vie");
                Console.ReadKey();

                while (listMonstres[compteur].Health > 0 && personnage.Health > 0)
                {
                    int degatMonstre = listMonstres[compteur].arme.Lancer() + Carac.ModCarac(listMonstres[compteur].Strength);
                    Console.WriteLine($" Point de vie du personnage({personnage.Health})");
                    Console.WriteLine($" Point de vie du monstre({listMonstres[compteur].Health})");
                    listMonstres[compteur].Health -= (ArmePlayer.DeArme.Lancer() + Carac.ModCarac(personnage.Strength));
                    Console.WriteLine($"Le monstre n'a plus que : {listMonstres[compteur].Health}PV");
                    if(listMonstres[compteur].Health > 0)
                    {
                        if(degatMonstre > ArmurePlayer.NbReduction)
                        {
                            personnage.Health -= degatMonstre - ArmurePlayer.NbReduction;
                        }                        
                    }
                    Console.WriteLine($"Le Personnage n'a plus que : {personnage.Health}PV");
                }
                if (listMonstres[compteur].Health <= 0)
                {
                    Console.WriteLine($"Le monstre : {listMonstres[compteur].GetType().Name} est mort !");
                    switch (listMonstres[compteur])
                    {
                        case Gobelin gob:
                            if(gob.inventaire.Count() > 0)
                            {
                                foreach (Equipement item in gob.inventaire)
                                {
                                    Console.WriteLine($"Vous avez gagné un(e) : {item.Name}");
                                    personnage.inventaire.Add(item);
                                    
                                }
                            }else
                            {
                                Console.WriteLine("Désolé le monstre n'a pas de loot.");
                            }
                            Console.WriteLine($"Vous avea gagné {gob.GoldQuantity} Po.");
                            personnage.GoldQuantity += gob.GoldQuantity;
                            break;
                        case Orc orc:
                            if (orc.inventaire.Count() > 0)
                            {
                                foreach (Equipement item in orc.inventaire)
                                {
                                    Console.WriteLine($"Vous avez gagné un(e) : {item.Name}");
                                    personnage.inventaire.Add(item);
                                    

                                }
                            }else
                            {
                                Console.WriteLine("Désolé le monstre n'a pas de loot.");
                            }
                            Console.WriteLine($"Vous avea gagné {orc.GoldQuantity} Po.");
                            personnage.GoldQuantity += orc.GoldQuantity;
                            break;
                        default:
                            Console.WriteLine("Désolé le monstre n'a pas de loot.");
                            break;
                    }
                    
                }
                
                Console.ReadKey();
                compteur++;
                Shop.MenuCommand(listDesEquipements, personnage);
            }
            if (personnage.Health > 0)
            {
                Console.WriteLine("Vous avez gagné");
            }
            else 
            {
                Console.WriteLine("Vous êtes mort !");
            }
        }
    }
}
