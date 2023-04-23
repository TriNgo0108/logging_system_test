using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web.Http.Filters;
using Serilog;

namespace analyze_1.services
{
    public class Filters : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            Log.Error("Occur exception {Exception}",context.Exception);
            var httpMessage = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            httpMessage.Content = new StringContent("Oops! Something is wrong. Please try again");
            context.Response = httpMessage ;
        }
    }
}