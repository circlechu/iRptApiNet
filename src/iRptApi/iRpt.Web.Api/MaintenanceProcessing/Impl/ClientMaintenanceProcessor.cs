using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iRpt.Common.TypeMapping;
using iRpt.Data.Entities;
using iRpt.Data.QueryProcessors;
using iRpt.Web.Api.Models;

namespace iRpt.Web.Api.MaintenanceProcessing.Impl
{
    public class ClientMaintenanceProcessor:IClientMaintenanceProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IClientQueryProcessor _queryProcessor;

        public ClientMaintenanceProcessor(IAutoMapper autoMapper, IClientQueryProcessor queryProcessor)
        {
            _autoMapper = autoMapper;
            _queryProcessor = queryProcessor;
        }

        public ClientModel AddClient(ClientModel newClient)
        {
            var client = _autoMapper.Map<Client>(newClient);
            _queryProcessor.AddClient(client);
            var clientModel = _autoMapper.Map<ClientModel>(client);
            return clientModel;
        }
    }
}