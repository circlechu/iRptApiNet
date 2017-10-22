using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRpt.Web.Api.Models
{
    public class Client
    {
        public Client() { }
        public long Clientid { get; set; }
        public string Clientcode { get; set; }
        public string Clientname { get; set; }
    }
}
