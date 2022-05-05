using System;
using SFMP.metier;
using System.Text.RegularExpressions;

namespace SystemeFacturationConsole
{
    class Program
    {
        static SystemeFacturationController sfc = new SystemeFacturationController();

        static void Main(string[] args)
        {
            
        }

        static void ListerFactures()
        {
            string listeFactures = "";
            foreach (Facture facture in sfc.AllFactures)
            {
                listeFactures += "#" + facture.NoFacture + " Client : " + facture.ClientFacture.Prenom + " " + facture.ClientFacture.Nom + "\n";
            }
            Console.WriteLine(listeFactures);
        }

        static void OuvrirFacture(long noFacture)
        {
            sfc.GetFacture(noFacture).ToString();
        }

        static void CreerNouvelleFacture(string nom, string prenom, string adrssCourriel)
        {
            sfc.CreerFacture(nom, prenom, adrssCourriel);
        }

        static void AjouterItemFacture(long noFacture, string descrption, decimal prix, int quantite)
        {
            sfc.AjouterItemFacture(noFacture, descrption, prix, quantite);
        }

        static void ModifierItemFacture(long noFacture, long noItem, string descrption, decimal prix, int quantite)
        {
            sfc.MettreAjourItemFacture(noFacture, noItem, descrption, prix, quantite);
        }

        static void SupprimerItemFacture(long noFacture, long noItem)
        {
            sfc.SupprimerItemFacture(noFacture, noItem);
        }

    }
}
