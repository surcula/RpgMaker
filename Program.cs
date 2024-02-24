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
 */

#endregion

using RpgMaker.Models;

Guerrier guerrier = new Guerrier();
guerrier.Name = "Surcula";
guerrier.Initialize();
Console.WriteLine($"Voici les valeurs de mon guerrier {guerrier.Name} : Force ({guerrier.Force}) Endurance({guerrier.Endurance}) Sagesse({guerrier.Sagesse}) Intelligence({guerrier.Intelligence})");