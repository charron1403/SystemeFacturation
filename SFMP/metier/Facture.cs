using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.metier
{
    public class Facture
    {
        public static decimal TPS = 0.05m;
        public static decimal TVQ = 0.09975m;

        private long noFacture;
        private Client client;
        private List<Item> items;
        private DateTime date;
        private decimal sousTotal = 0;
        private bool recalculerSousTotal = true;

        public Facture(Client client_)
        {
            this.client = client_;
            items = new List<Item>();
        }

        public long NoFacture { get => noFacture; set => noFacture = value; }
        public DateTime Date { get => date; set => date = value; }
        public Client ClientFacture { get => client; }
        public List<Item> Items { get => items; }
        public decimal SousTotal 
        { 
            get 
            {
                return sousTotal;
            }
            set
            {
                if (RecalculerSousTotal)
                {
                    sousTotal = 0;
                    
                    foreach (Item item in Items)
                    {
                        sousTotal += (item.PrixUnitaire * item.Quantite);
                    }
                }
            }
        }
        public decimal Tps { get => TPS * SousTotal; }
        public decimal Tvq { get => TVQ * SousTotal; }
        public decimal Total { get => SousTotal + Tps + Tvq; }
        public bool RecalculerSousTotal { get => recalculerSousTotal; set => recalculerSousTotal = value; }

        public void AjouterItem(Item item_)
        {
            items.Add(item_);
            SousTotal = 0;
        }

        public Item ModifierItem(long noItem, string nvlleDescription, decimal nvPrix, int nvlleQuantite)
        {
            items[(int)noItem - 1] = new Item(nvlleDescription, nvPrix, nvlleQuantite);
            SousTotal = 0;
            return items[(int)noItem - 1];
        }

        public void SupprimerItem(long noItem)
        {
            items.RemoveAt((int)noItem - 1);
            SousTotal = 0;
        }

        public override string ToString()
        {
            string listeItems = "";
            string espaces = "  ........................................  ";
            if (items.Count > 0)
            {
                foreach (Item item in items)
                {
                    listeItems += ("\n#" + item.NoItem + " " + item.Description + espaces.Substring(2, item.Description.Length) + "x" + item.Quantite.ToString() + " " + item.Cout.ToString() + "$");
                }
            }
            return "FACTURE No." + NoFacture.ToString() + "\n-----------------------\n\nClient\n.-.-.-.-.-.\nPrénom: " 
                    + ClientFacture.Prenom + "\nNom: " + ClientFacture.Nom + "\nAdresse email: " + ClientFacture.AdresseCourriel 
                    + "\n\nITEMS\n-.-.-.-.-" + listeItems + "\n\nSOUS-TOTAL : " + sousTotal.ToString() + "$\nTPS : " + Tps.ToString() 
                    + "$\nTVQ : " + Tvq.ToString() + "$\nTOTAL : " + Total.ToString() + "$";
        }
    }
}
