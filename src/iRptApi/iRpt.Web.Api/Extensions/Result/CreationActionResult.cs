using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace iRpt.Web.Api.Extensions.Result
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
            return Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            var responseMessage = _requestMessage.CreateResponse(
                HttpStatusCode.Created, _created);

            return responseMessage;
        }
    }
}