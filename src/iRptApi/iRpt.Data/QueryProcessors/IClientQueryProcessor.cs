using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iRpt.Data.Entities;

namespace iRpt.Data.QueryProcessors
{
    public interface IClientQueryProcessor
    {
        void AddClient(Client client);

        Client GetClient(long clientId);

        void UpdateClient(Client client);

    }
}
