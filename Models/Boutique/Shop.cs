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
        public static void MenuCommand(List<Equipement> listDesEquipements)
        {
            int choiceUser = 0;
            do
            {
                Console.WriteLine("Bienvenue dans la boutique. Veuillez choisir un menu.");
                Console.WriteLine("1:Acheter");
                Console.WriteLine("2:Vendre");
                Console.WriteLine("3:Quitter");
            } while (choiceUser > 3 && choiceUser < 0);


            switch (choiceUser)
            {
                case 1:
                    Acheter(listDesEquipements);
                    break;
                case 2:
                    Vendre();
                    break;
                case 3:
                    break;
            }
        }

        /// <summary>
        /// Vendre les objets
        /// </summary>
        private static void Vendre()
        {
            
        }

        /// <summary>
        /// Acheter les objets
        /// </summary>
        /// <param name="listDesEquipements"></param>
        private static void Acheter(List<Equipement> listDesEquipements)
        {
            if (listDesEquipements.Count() != 0)
            {
                Console.WriteLine("Veuillez choisir un objet à acheter.");
                int compteur = 0;
                foreach (Equipement item in listDesEquipements)
                {
                    Console.WriteLine($"{compteur}:{item.Name}({item.GoldQuantity}Po)");
                    compteur++;
                }

            }
        }
    }
}
