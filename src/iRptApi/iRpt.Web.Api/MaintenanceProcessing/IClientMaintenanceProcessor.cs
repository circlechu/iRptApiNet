using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iRpt.Web.Api.Models;

namespace iRpt.Web.Api.MaintenanceProcessing
{
    public interface IClientMaintenanceProcessor
    {
        ClientModel AddClient(ClientModel newClient);
    }
}
