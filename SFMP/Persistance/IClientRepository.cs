using System;
using System.Collections.Generic;
using System.Text;
using SFMP.metier;

namespace SFMP.Persistance
{
    interface IClientRepository
    {
        public Client Select(long noClient);

        public void Insert(Client c);
    }
}
