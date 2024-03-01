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

+++++++++++++++++++++++++++++++

Intégration du système de jeu : N'hésitez pas à faire TOUTE les modifications qui vous parraissent necéssaires

Modificateur de caractéristiques
	Le modificateur est un bonus amené par une valeur élevées dans une carac (quelque soit la carac)
	En dessous de 10 => -1
	10 à 12 => 0
	13 à 15 => +1
	16 à 18 => +2
	19 à 21 => +3 
	...
	

Ajouter une valeur de point de vie aux différentes entités (personnage, monstres), ceux ci sont calculé comme suit : 

	10 + Modificateur d'endurance.

	Ceux ci, sont calculé à la création du personnage

----

Lors de la création du personnage, il obtient 100pieces d'or pour acheter son équipement de départ.
	=> Mettre en place la "boutique" vendant chaque objet du jeu en quantité illimité


--> Système de combat <--

Le combat se déroule comme suit. 
	1) le joueur choisit l'arme à utilisé pour attaquer parmi celle présente dans son inventaire
	2) Les dégats de l'attaque sont calculé en fonction des dégats de l'arme + modificateur de force.
	3) Le monstre perds un nbr de PV = aux dégats infligé.
	4) au tour du monstre de frapper
		=> Goblin : 1D4+ modificateur de force
		=> Orc : 1D8 + modificateur de force
		=> Loup : 1D6 + Modificateur de force

	5) Le joueur perd un montant de PV égal à : 
		=> Dégat du monstre - Reduction de dégat de l'armure

	6) on recommence au point 1

Résultat : 
	Si le joueur est mort, la partie s'arrête
	Si le joueur est vivant, 
		1) il récupère les loots du monstre si applicable
		2) il peut passer par la boutique vendre (à la moitié du prix) ou acheter
		3) il peut utiliser des potion pour se soigner

		4) le combat suivant se déclenche


PRIX des équipements : 
	Epée courte : 15po
	Epée longue : 25po
	Baton : 10po
	Armure de cuir : 20po
	Armure de plaque : 50po
	Potion de soin : 20po

!!! BONUS !!!
Changer le système de création de personnage : 
	1) Choix de la classe de personnage
	2) Choix du nom
	3) 4 jet de 4D6 seront effectuer et montrer au joueur
	4) il pourra alors affecté les différentes valeurs aux caractéristiques voulues
		=> la console demandera les valeurs pour Force, Endurance, Intelligence et Sagesse (dans cet ordre)

	4') Tâcher de vérifier que la valeur utilisée existe bien dans les 4 proposées par le jet de dés et n'est pas utilisée 2 fois

 */

#endregion

using RpgMaker.Models;
using RpgMaker.Models.Characters;
using RpgMaker.Models.Monstres;
using RpgMaker.Models.Objets;
using RpgMaker.Models.Tools;



//Guerrier guerrier = new Guerrier();
//guerrier.ShowCharacterProfile();


//Mage mage = new Mage();
//mage.ShowCharacterProfile();

//Pretre pretre = new Pretre();
//pretre.ShowCharacterProfile();

//Console.WriteLine("Appuyer sur une touche pour continuer .......");
//Console.ReadKey();
//Console.Clear();

//int choiceUser = 0;

//Personnage personnage = new Personnage();

//while (choiceUser < 1 || choiceUser > 3)
//{
//	Console.WriteLine("Quelle classe voulez-vous jouer ? ");
//	Console.WriteLine("1. Guerrier");
//	Console.WriteLine("2. Mage");
//	Console.WriteLine("3. Prêtre");
//	choiceUser = int.Parse(Console.ReadLine());

//}
//switch (choiceUser)
//{
//	case 1:
//		personnage = new Guerrier();
//		break;
//	case 2:
//		personnage = new Mage();
//		break;
//	case 3:
//		personnage = new Pretre();
//		break;
//	default:
//		break;
//}

//if (personnage != null)
//{

//	Console.WriteLine("Veuillez entre le nom du personnage : ");
//	personnage.ShowCharacterProfile();
//}


//Console.WriteLine("Appuyer sur une touche pour continuer .......");
//Console.ReadKey();
//Console.Clear();


//Monstre monstre1 = new Monstre();
//monstre1 = new Gobelin();
//Gobelin g = (Gobelin)monstre1;
//g.ShowCharacterProfile();
//g.CoupDeMasse();


//Monstre monstre2 = new Monstre();
//monstre2 = new Loup();
//Loup l = (Loup)monstre2;
//l.ShowCharacterProfile();
//l.Morsure();
//l.Hurlement();

//Monstre monstre3 = new Monstre();
//monstre3 = new Orc();
//Orc o = (Orc)monstre3;
//o.ShowCharacterProfile();
//o.CoupDeHache();
//o.CriDeGuerre();

Jeu j = new Jeu();
j.RandomList();
j.AfficherMonstre();



#region Boxing UnBoxing

//Monstre m = new Monstre(); Fonctionnera pas !!!!
Monstre m = new Gobelin(); //Boxing
Gobelin g1 = (Gobelin)m; //Unboxing
((Gobelin)m).CoupDeMasse(); // ça évite de créer des objets un peu partout.


#endregion

#region CreationDesObjets

Arme arme = new Arme("Epee Courte",15,new De(1,6));
Arme arme2 = new Arme("Epee Longue",25,new De(1,8));
Arme arme3 = new Arme("baton",10,new De(1,4));

Armure armure = new Armure("Armure de cuir",20,2);
Armure armure2 = new Armure("Armure de plaque",50,5);

Consommable consommable = new Consommable("potion de vie",20);


j.listDesEquipements.Add(arme);
j.listDesEquipements.Add(arme2);
j.listDesEquipements.Add(arme3);
j.listDesEquipements.Add(armure);
j.listDesEquipements.Add(armure2);
j.listDesEquipements.Add(consommable);
#endregion

j.EntrerBoutique();
Console.ReadLine();
Console.Clear();


Gobelin gob = new Gobelin();
gob.GoldQuantity = new Random().Next(1, 101);
gob.AttribuerObjet(j.listDesEquipements);
gob.Death();
Console.ReadLine();

Orc orc = new Orc();
orc.GoldQuantity = new Random().Next(1, 101);
orc.AttribuerObjet(j.listDesEquipements);
orc.Death();

Console.ReadLine();