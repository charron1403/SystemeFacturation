using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.metier
{
    public class Client
    {
        private long noClient;
        private string nom;
        private string prenom;
        private string adresseCourriel;

        public Client (string nom_, string prenom_, string adresseCourriel_)
        {
            this.nom = nom_;
            this.prenom = prenom_;
            this.adresseCourriel = adresseCourriel_;
        }

        public long NoClient { get => noClient; set => noClient = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string AdresseCourriel { get => adresseCourriel; set => adresseCourriel = value; }
    }
}
