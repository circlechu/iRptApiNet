using System;
using iRpt.Common.Adapters;
using iRpt.Common.Security;
using iRpt.Data.Entities;
using iRpt.Data.QueryProcessors;
using NHibernate;

namespace iRpt.Data.SqlServer.QueryProcessors
{
    public class ClientQueryProcessor : IClientQueryProcessor
    {
        private readonly IDateTime _dateTime;
        private readonly ISession _session;
        private readonly IUserSession _userSession;

        public ClientQueryProcessor(ISession session, IUserSession userSession, IDateTime dateTime)
        {
            _session = session;
            _userSession = userSession;
            _dateTime = dateTime;
        }


        public void AddClient(Client client)
        {
            _session.SaveOrUpdate(client);
        }

        public Client GetClient(long clientId)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
