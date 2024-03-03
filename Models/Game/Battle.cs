using RpgMaker.Models.Characters;
using RpgMaker.Models.Monstres;
using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public static void InitBatttle(Personnage personnage, List<Monstre> listMonstres)
        {
            InitLists(personnage);
            ChoiceArme(personnage);
            ChoiceArmure(personnage);
            BattleHorde(personnage, listMonstres);

        }

        private static void ChoiceArme(Personnage personnage)
        {
            int choiceUser = 0;

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

        private static void ChoiceArmure(Personnage personnage)
        {
            int choiceUser = 0;


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
        private static void BattleHorde(Personnage personnage, List<Monstre> listMonstres)
        {
            for (int i = 0; i < listMonstres.Count(); i++)
            {
                Console.WriteLine($"Le combat : {i} débute ...... Il vous reste {personnage.Health} point de vie");
                Console.ReadKey();

                while (listMonstres[i].Health > 0 && personnage.Health > 0)
                {
                    Console.WriteLine($" Point de vie du personnage({personnage.Health})");
                    Console.WriteLine($" Point de vie du monstre({listMonstres[i].Health})");
                    listMonstres[i].Health -= (ArmePlayer.DeArme.Lancer() + Carac.ModCarac(personnage.Strength));
                    Console.WriteLine($"Le monstre n'a plus que : {listMonstres[i].Health}PV");
                    personnage.Health -= ((listMonstres[i].arme.Lancer() + Carac.ModCarac(listMonstres[i].Strength)) - ArmurePlayer.NbReduction);
                    Console.WriteLine($"Le Personnage n'a plus que : {personnage.Health}PV");

                }
                if(personnage.Health <= 0)
                {
                    Console.WriteLine("Vous êtes Mort");
                }
                
            }
            if (personnage.Health > 0)
            {
                Console.WriteLine("Vous avez gagné");
            }
        }
    }
}
