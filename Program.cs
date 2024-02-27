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

 */

#endregion

using RpgMaker.Models;
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
