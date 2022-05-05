using SFMP.metier;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.Persistance
{
    class ClientMysqlRepository : MysqlRepository, IClientRepository
    {
        protected ClientMysqlRepository(string adrServeur, string nomBD, string nomUtilisateur, string motDePasse, int port) : base(adrServeur, nomBD, nomUtilisateur, motDePasse, port)
        {
        }

        public void Insert(Client c)
        {
            throw new NotImplementedException();
        }

        public Client Select(long noClient)
        {
            throw new NotImplementedException();
        }
    }
}
