using System;
using System.Collections.Generic;
using System.Text;
using SFMP.metier;

namespace SFMP.Persistance
{
    interface IItemRepository
    {
        public List<Item> SelectAllItemFacture(long noFacture);

        public void Insert(long noFacture, Item i);

        public void Update(Item i);

        public void Delete(long noItem);
    }
}
