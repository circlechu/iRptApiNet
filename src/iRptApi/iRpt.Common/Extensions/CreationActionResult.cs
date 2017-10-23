using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace iRpt.Common.Extensions
{
    public class CreationActionResult<T> : IHttpActionResult
    {
        private readonly T _created;
        private readonly HttpRequestMessage _requestMessage;
        public CreationActionResult(HttpRequestMessage requestMessage,
            T created)
        {
            _requestMessage = requestMessage;
            _created = created;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            var responseMessage = _requestMessage.CreateResponse(
                HttpStatusCode.Created, _created);

            return responseMessage;
        }
    }
}
