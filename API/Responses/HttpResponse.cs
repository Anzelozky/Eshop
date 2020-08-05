using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace API.Responses
{
    public class HttpResponse<T>
    {
        public HttpStatusCode Status;
        public string Message { get; set; }
        public T Data { get; set; }

        public HttpResponse(HttpStatusCode statusCode, T data = default, string message = null)
        {
            Status = statusCode;
            Message = message;
            Data = data;
        }

        public IActionResult Result
        {
            get
            {
                var result = new ObjectResult(new {Status,Message,Data})
                {
                    StatusCode = (int)Status
                };
                return result;
            }
        }
    }
}