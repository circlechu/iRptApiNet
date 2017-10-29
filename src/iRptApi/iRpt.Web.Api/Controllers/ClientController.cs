using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using iRpt.Web.Api.Extensions.Result;
using iRpt.Web.Api.MaintenanceProcessing;
using iRpt.Web.Api.Models;

namespace iRpt.Web.Api.Controllers
{
    public class ClientController : ApiController
    {
        private readonly IClientMaintenanceProcessor _clientMaintenanceProcessor;

        public ClientController(IClientMaintenanceProcessor clientMaintenanceProcessor)
        {
            _clientMaintenanceProcessor = clientMaintenanceProcessor;
        }

//        [Route("{id:long}", Name = "GetClientRoute")]
        public ClientModel GetClient(long id)
        {
            var client = new ClientModel {Clientid = id, Clientcode = "MATA", Clientname = "Miracle Capital"};
            return client;
        }

        [AllowAnonymous]
        public IEnumerable<ClientModel> GetClients()
        {
            var client = new ClientModel {Clientid = 1, Clientcode = "MATA", Clientname = "Miracle Capital"};
            return new List<ClientModel> {client};
        }

        [HttpPost]
        public IHttpActionResult AddClient(HttpRequestMessage requestMessage, ClientModel newClient)
        {
            /*
            POST http://localhost:36553/api/client HTTP/1.1
            Content-Type: text/json

            {"ClientCode":"MATA","ClientName":"Miracle Capital"}

             */
            var client = _clientMaintenanceProcessor.AddClient(newClient);
            var result = new CreationActionResult<ClientModel>(requestMessage, client);
            return result;
        }


        [HttpPut]
        public ClientModel UpdateClient(long id, [FromBody] object updatedClient)
        {
            /*
              PUT http://localhost:36553/api/client/1 HTTP/1.1
              Content - type: application / json

              { "ClientCode":"MATA","ClientName":"Miracle Capital"}
            */

            var client = new ClientModel {Clientid = id, Clientname = "Client 1", Clientcode = "client1"};
            return client;
        }

        [HttpDelete]
        public IHttpActionResult DeleteClient(long id)
        {
            return Ok();
        }
    }
}