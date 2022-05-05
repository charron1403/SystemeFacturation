using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.metier
{
    public class SystemeFacturationException
    {
        public SystemeFacturationException()
        {

        }

        //public void Erreurs(string type)
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("[Erreur] ");
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    switch (type)
        //    {
        //        case "invalide":
        //            Console.WriteLine("Opération impossible : argument invalide");
        //            break;
        //        case "inconnu":
        //            Console.WriteLine("Opération impossible : commande inconnue");
        //            break;
        //        case "facture":
        //            Console.WriteLine("Opération impossible : Aucune facture n'a été créée");
        //            break;
        //        case "item":
        //            Console.WriteLine("Opération impossible : Il n'y a aucun item sur cette facture");
        //            break;
        //        case "prenom":
        //            Console.WriteLine("Le prénom ne doit contenir que des lettres");
        //            break;
        //        case "nom":
        //            Console.WriteLine("Le nom ne doit contenir que des lettres");
        //            break;
        //        case "email":
        //            Console.WriteLine("L'adresse courriel est invalide");
        //            break;
        //    }
        //    Console.ForegroundColor = ConsoleColor.White;
        //}
        //public void Erreurs(string type, int noPosition)
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("[Erreur] ");
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    switch (type)
        //    {
        //        case "facture":
        //            Console.WriteLine("Opération impossible : La facture No." + noPosition.ToString() + " n'existe pas");
        //            break;
        //        case "item":
        //            Console.WriteLine("Opération impossible : L'item No." + noPosition.ToString() + " n'existe pas");
        //            break;
        //    }
        //    Console.ForegroundColor = ConsoleColor.White;
        //}
    }
}
