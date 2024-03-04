using RpgMaker.Models.Characters;
using RpgMaker.Models.Objets;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Boutique
{
    public static class Shop
    {
        /// <summary>
        /// Le menu de la boutique
        /// </summary>
        /// <param name="listDesEquipements"></param>
        /// <param name="inventaire"></param>
        public static void MenuCommand(List<Equipement> listDesEquipements, Personnage personnage)
        {

            int choiceUser = 0;
            do
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Bienvenue dans la boutique. Veuillez choisir un menu.");
                    Console.WriteLine("1:Acheter");
                    Console.WriteLine("2:Vendre");
                    Console.WriteLine("3:Quitter");
                    choiceUser = int.Parse(Console.ReadLine());
                } while (choiceUser > 3 && choiceUser < 0);


                switch (choiceUser)
                {
                    case 1:
                        Acheter(listDesEquipements, personnage);
                        break;
                    case 2:
                        Vendre(personnage);
                        break;
                    case 3:
                        break;
                }


            } while (choiceUser != 3);

        }

        /// <summary>
        /// Vendre les objets
        /// </summary>
        private static void Vendre(Personnage personnage)
        {

            int choixUser = 1;

            if (personnage.inventaire.Count() != 0)
            {
                while (choixUser > 0 || choixUser < personnage.inventaire.Count)
                {
                    Console.WriteLine($"Veuillez choisir un objet à vendre.");
                    Console.WriteLine("0 : pour quitter.");
                    for (int i = 0; i < personnage.inventaire.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}:{personnage.inventaire[i].Name} (Valeur : {(personnage.inventaire[i].GoldQuantity) / 2}Po)");
                    }
                    choixUser = int.Parse(Console.ReadLine());

                    if (choixUser != 0)
                    {
                        Console.WriteLine($"Voici votre or : {(personnage.inventaire[choixUser - 1].GoldQuantity) / 2}");
                        personnage.GoldQuantity += (personnage.inventaire[choixUser - 1].GoldQuantity) / 2;
                        personnage.inventaire.Remove(personnage.inventaire[choixUser - 1]);

                    }
                }

                
            }
            else
            {
                Console.WriteLine("Désolé mais vous n'avez pas encore d'objet a vendre, revenez plus tard !");
            }


        }

        /// <summary>
        /// Acheter les objets
        /// </summary>
        /// <param name="listDesEquipements"></param>
        private static void Acheter(List<Equipement> listDesEquipements, Personnage personnage)
        {
            Console.Clear();
            int choixUser = 0;
            do
            {
                if (listDesEquipements.Count() != 0)
                {

                    Console.Clear();
                    Console.WriteLine($"Veuillez choisir un objet à acheter. vous avez actuellement {personnage.GoldQuantity}Po");
                    Console.WriteLine("0 : pour quitter.");
                    for (int i = 0; i < listDesEquipements.Count; i++)
                    {

                        Console.WriteLine($"{i + 1}:{listDesEquipements[i].Name}({listDesEquipements[i].GoldQuantity}Po)");

                    }
                }
                choixUser = int.Parse(Console.ReadLine());

                if (choixUser != 0)
                {
                    if (personnage.GoldQuantity > listDesEquipements[choixUser - 1].GoldQuantity)
                    {
                        personnage.inventaire.Add(listDesEquipements[choixUser - 1]);
                        personnage.GoldQuantity -= listDesEquipements[choixUser - 1].GoldQuantity;
                    }
                    else
                    {
                        Console.WriteLine("Tu n'as pas assez d'or pour cet objet.");
                    }
                }

            } while (choixUser != 0);
            
            Console.WriteLine("Au revoir aventurier !");

        }
    }
}
