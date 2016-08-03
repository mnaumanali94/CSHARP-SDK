/*
 * Tester.Tests
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/03/2016
 */
using Tester.PCL.Http.Client;
using Tester.PCL.Http.Request;
using Tester.PCL.Http.Response;

namespace Tester.Tests.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}
