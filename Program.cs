using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue chez le loueur de bateaux!");

        Console.WriteLine("Choisissez votre type de bateau (1 pour voile, 2 pour moteur):");

        int choix = Convert.ToInt32(Console.ReadLine());

        Bateau bateau;
        if (choix == 1)
        {
            bateau = new Voilier();
        }
        else if (choix == 2)
        {
            bateau = new BateauMoteur();
        }
        else
        {
            Console.WriteLine("Vous avez selectionné un bateau non existant, veuillez recommencer");
        }

        Console.WriteLine($"Entrez le nombre de passagers pour le {bateau.Type}:");

        int passagers = Convert.ToInt32(Console.ReadLine());

        if (!bateau.SetPassagers(passagers))
        {
            Console.WriteLine("Nombre de passagers trop important pour ce type de bateau.");
            return;
        }

        Console.WriteLine("Le bateau est de retour. Vérification de l'inventaire en cours...");

        if (bateau.VerifierInventaire())
        {
            Console.WriteLine("Tout est correct avec l'inventaire.");
        }
        else
        {
            Console.WriteLine("Des éléments sont manquants dans l'inventaire.");
        }
    }
}





