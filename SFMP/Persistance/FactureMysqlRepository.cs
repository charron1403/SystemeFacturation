using SFMP.metier;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.Persistance
{
    class FactureMysqlRepository : MysqlRepository, IFactureRepository
    {
        protected FactureMysqlRepository(string adrServeur, string nomBD, string nomUtilisateur, string motDePasse, int port) : base(adrServeur, nomBD, nomUtilisateur, motDePasse, port)
        {
        }

        private ClientMysqlRepository clientRepo;
        private ItemMysqlRepository itemRepo;

        public void Insert(Facture f)
        {
            throw new NotImplementedException();
        }

        public Facture Select(long noFacture)
        {
            throw new NotImplementedException();
        }

        public List<Facture> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Facture f)
        {
            throw new NotImplementedException();
        }
    }
}
