using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iRpt.Common.Extensions;
using iRpt.Web.Api.Models;
using Newtonsoft.Json;

namespace iRpt.Web.Api.Controllers
{
    public class ClientController : ApiController
    {
//        [Route("{id:long}", Name = "GetClientRoute")]
        public Client GetClient(long id)
        {
            return  new Client {Clientid= id,Clientcode = "MATA",Clientname = "Miracle Capital"};
        }

        [HttpPost]
        public IHttpActionResult AddClient(HttpRequestMessage requestMessage, Client newClient)
        {

            /*
            POST http://localhost:36553/api/client HTTP/1.1
            Content-Type: text/json

            {"ClientCode":"MATA","ClientName":"Miracle Capital"}

             */
            newClient.Clientid = 2;
            var result = new CreationActionResult<Client>(requestMessage, newClient);
            return result;
        }



        [HttpPut]
        public Client UpdateClient(long id, [FromBody] object updatedClient)
        {
            /*
              PUT http://localhost:36553/api/client/1 HTTP/1.1
              Content - type: application / json

              { "ClientCode":"MATA","ClientName":"Miracle Capital"}
            */

            var client = new Client {Clientid = id, Clientname = "Client 1", Clientcode = "client1"};
            return client;
        }

        [HttpDelete]
        public IHttpActionResult DeleteClient(long id)
        {
            
            return Ok();
        }
    }

    

}
