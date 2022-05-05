using System;
using System.Collections.Generic;
using System.Text;
using SFMP.Persistance;

namespace SFMP.metier
{
    public class SystemeFacturationController
    {
        ClientMysqlRepository clientMysqlRepository;
        FactureMysqlRepository factureMysqlRepository;
        ItemMysqlRepository itemMysqlRepository;

        private long compteurNoFacture = 0;
        private long compteurNoItem = 0;
        private long compteurNoClient = 0;
        Dictionary<long, Facture> factures;
        
        public long CompteurNoFacture { get => compteurNoFacture; }
        public long CompteurNoItem { get => compteurNoItem; }
        public long CompteurNoClient { get => compteurNoClient; }
        public List<Facture> AllFactures
        {
            get
            {
                return factureMysqlRepository.SelectAll();
            }
        }

        public SystemeFacturationController()
        {
            factures = new Dictionary<long, Facture>();
        }

        public Facture GetFacture(long noFacture)
        {
            return factureMysqlRepository.Select(noFacture);
        }

        public Facture CreerFacture(string nom, string prenom, string adrssCourriel)
        {
            Facture newFacture = new Facture(new Client(nom, prenom, adrssCourriel));
            factureMysqlRepository.Insert(newFacture);
            compteurNoFacture++;
            compteurNoClient++;
            return newFacture;
        }

        public void AjouterItemFacture(long noFacture, string description, decimal prix, int quantite)
        {
            itemMysqlRepository.Insert(noFacture, new Item(description, prix, quantite));
            compteurNoItem++;
        }

        public void MettreAjourItemFacture(long noFacture, long noItem, string description, decimal prix, int quantite)
        {
            itemMysqlRepository.Update(factureMysqlRepository.Select(noFacture).ModifierItem(noItem, description, prix, quantite));
        }

        public void SupprimerItemFacture(long noFacture, long noItem)
        {
            itemMysqlRepository.Delete(noItem);
            factureMysqlRepository.Select(noFacture).SupprimerItem(noItem);
        }


    }
}
