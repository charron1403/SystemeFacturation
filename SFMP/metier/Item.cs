using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.metier
{
    public class Item
    {
        private long noItem;
        private string description;
        private decimal prixUnitaire;
        private int quantite;

        public Item(string description_, decimal prixUnitaire_, int quantite_)
        {
            this.Description = description_;
            this.PrixUnitaire = prixUnitaire_;
            this.Quantite = quantite_;
        }

        public long NoItem { get => noItem; set => noItem = value; }
        public string Description { get => description; set => description = value; }
        public decimal PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public decimal Cout { get => prixUnitaire * quantite; }
        public override string ToString()
        {
            return description + " " + prixUnitaire.ToString() + "$ x" + quantite.ToString();
        }
    }
}
