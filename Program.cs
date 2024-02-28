#region Enoncé

/*
 * Définir les classes suivantes 

Personnages
Guerrier, Pretre, Mage

Chaque personnage sera définie par 
	- Nom (du perso)
		
		!!Caractéristique!!
	- Force, Endurance, Intelligence, Sagesse
		chaque carac sera en lecture seule

		une méthode qui va créer les valeurs de base (tips : utiliser la méthode random de la classe)
			Valeur comprise entre 10 et 20


Si guerrier => Force et Endurance + 3
Si pretre => Sagesse + 4 Intel + 2
Si mage => Intel + 4 Sagesse + 2
-----------------------------------------------------------------------------------------------

Utiliser l'héritage en créant une nouvelle classe Personnage.
------------------------------------------------------------------------------------------------
Créer 3 monstres différents (Goblin[-1Force], Loup[+2Force,+1Endu], Orc[+3Force,+2Endu])
chaque monstre à une force et une endurance

Gobelin peut mettre un coup de masse.
Loup peut mettre une morsure ou un hurlement
L'orc peut mettre un coup de hache ou un cri de guerre ("Encore du travail")

Faire une liste de 10 monstres de type aléatoire

1 chance sur 2 de croiser un goblin
1 chance sur 3 de croiser un loup
1 chance sur 6 de croiser un orc
--------------------------------------

Créer une classe qui va regrouper les déclarations communes (méthodes et propriétés) à monstres et personnages.
Modifier classe Monstre et Personnage pour qu'elles continuent à fonctionner 
Réfléchir à ce qui peut devenir abstract.

--------------------------------------------

Interface : 
Implémenter un système d'équipement. Chaque équipement aura un prix en pièce d'or et un nom.

3 catégories : Armes, Armures, Consommables

Arme : dégat
Armure : Réduction de dégat
Consommable : Effet
			=> Sous forme de méthode

Qui peut avoir un équipement ? 
			=> Les personnages pour l'utiliser
			=> Les monstres pour le looter (gobelin et orc)
						=> Les loups n'ont pas d'inventaire.

Ajouter la notion de pièce d'or pour les personnages.

Bonus générer un inventaire aléatoire pour les loots des monstres (entre 0 et 2 objets).

-> Epée courte : 1d6
-> Epée longue : 1d8
-> Baton : 1d4

-> potion de soi: rend 2d4pv

-> armure de cuir : réduction 2 dégats
-> armure de plaque : réduction 5 dégats



 */

#endregion

using RpgMaker.Models;
using RpgMaker.Models.Characters;
using RpgMaker.Models.Monstres;
using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;
using System.Threading.Channels;



Guerrier guerrier = new Guerrier();
guerrier.Initialize();
guerrier.ShowCharacterProfile();

Mage mage = new Mage();
mage.Initialize();
mage.ShowCharacterProfile();

Pretre pretre = new Pretre();
pretre.Initialize();
pretre.ShowCharacterProfile();

Console.WriteLine("Appuyer sur une touche pour continuer .......");
Console.ReadKey();
Console.Clear();

int choiceUser = 0;

Personnage personnage = new Personnage();

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

if(personnage != null)
{
	personnage.Initialize();
    Console.WriteLine("Veuillez entre le nom du personnage : ");
    personnage.ShowCharacterProfile();
}


Console.WriteLine("Appuyer sur une touche pour continuer .......");
Console.ReadKey();
Console.Clear();


Monstre monstre1 = new Monstre();
monstre1 = new Gobelin();
monstre1.Initialize();
Gobelin g = (Gobelin)monstre1;
g.ShowCharacterProfile();
g.CoupDeMasse();


Monstre monstre2 = new Monstre();
monstre2 = new Loup();
monstre2.Initialize();
Loup l = (Loup)monstre2;
l.ShowCharacterProfile();
l.Morsure();
l.Hurlement();

Monstre monstre3 = new Monstre();
monstre3 = new Orc();
monstre3.Initialize();
Orc o = (Orc)monstre3;
o.ShowCharacterProfile();
o.CoupDeHache();
o.CriDeGuerre();

Jeu j = new Jeu();
j.RandomList();
j.AfficherMonstre();

Console.WriteLine("Appuyer sur une touche pour continuer .......");
Console.ReadKey();
Console.Clear();

#region Boxing UnBoxing

//Monstre m = new Monstre(); Fonctionnera pas !!!!
Monstre m = new Gobelin(); //Boxing
Gobelin g1 = (Gobelin)m; //Unboxing
((Gobelin)m).CoupDeMasse(); // ça évite de créer des objets un peu partout.


#endregion

#region CreationDesObjets

Arme arme = new Arme();
arme.Name = "Epee Courte";
arme.GoldQuantity = 15;
arme.DeArme = new De();
arme.DeArme.QuantiteDe = 1;
arme.DeArme.TypeDe = 6;

Arme arme2 = new Arme();
arme2.Name = "Epee Longue";
arme2.GoldQuantity = 20;
arme2.DeArme = new De();
arme2.DeArme.QuantiteDe = 1;
arme2.DeArme.TypeDe = 8;

Arme arme3 = new Arme();
arme3.Name = "baton";
arme3.GoldQuantity = 20;
arme3.DeArme = new De();
arme3.DeArme.QuantiteDe = 1;
arme3.DeArme.TypeDe = 4;

Armure armure = new Armure();
armure.Name = "Armure de cuir";
armure.GoldQuantity = 10;
armure.NbReduction = 2;

Armure armure2 = new Armure();
armure2.Name = "Armure de cuir";
armure2.GoldQuantity = 15;
armure2.NbReduction = 5;

Consommable consommable = new Consommable();
consommable.Name = "Potion de vie";
consommable.GoldQuantity = 5;

j.listDesEquipements.Add(arme);
j.listDesEquipements.Add(arme2);
j.listDesEquipements.Add(arme3);
j.listDesEquipements.Add(armure);
j.listDesEquipements.Add(armure2);
j.listDesEquipements.Add(consommable);

#endregion

Console.Clear();


Gobelin gob = new Gobelin();
gob.Initialize();
gob.GoldQuantity = new Random().Next(1, 101);
gob.AttribuerObjet(j.listDesEquipements);
gob.Death();
Console.ReadLine();

Orc orc = new Orc();
orc.Initialize();
orc.GoldQuantity = new Random().Next(1, 101);
orc.AttribuerObjet(j.listDesEquipements);
orc.Death();
Console.ReadLine();