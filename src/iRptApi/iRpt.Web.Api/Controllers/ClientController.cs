using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }

    

}
