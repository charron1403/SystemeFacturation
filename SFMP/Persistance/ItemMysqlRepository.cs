using SFMP.metier;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFMP.Persistance
{
    class ItemMysqlRepository : MysqlRepository, IItemRepository
    {
        protected ItemMysqlRepository(string adrServeur, string nomBD, string nomUtilisateur, string motDePasse, int port) : base(adrServeur, nomBD, nomUtilisateur, motDePasse, port)
        {
        }

        public void Delete(long noItem)
        {
            throw new NotImplementedException();
        }

        public void Insert(long noFacture, Item i)
        {
            throw new NotImplementedException();
        }

        public List<Item> SelectAllItemFacture(long noFacture)
        {
            throw new NotImplementedException();
        }

        public void Update(Item i)
        {
            throw new NotImplementedException();
        }
    }
}
