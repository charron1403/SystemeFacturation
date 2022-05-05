using System;
using System.Collections.Generic;
using System.Text;
using SFMP.metier;

namespace SFMP.Persistance
{
    interface IFactureRepository
    {
        public List<Facture> SelectAll();

        public Facture Select(long noFacture);

        public void Insert(Facture f);

        public void Update(Facture f);
    }
}
