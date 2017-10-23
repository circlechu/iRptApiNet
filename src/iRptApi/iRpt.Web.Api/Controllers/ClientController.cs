using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iRpt.Common.Extensions;
using iRpt.Web.Api.Models;

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
            newClient.Clientid = 2;
            var result = new CreationActionResult<Client>(requestMessage, newClient);
            return result;
        }
    }

    

}
