using iRpt.Web.Api.Models;

namespace iRpt.Web.Api.MaintenanceProcessing
{
    public interface IClientMaintenanceProcessor
    {
        ClientModel AddClient(ClientModel newClient);
    }
}