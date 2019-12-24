using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace Mvc
{
    public static class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

      static  GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:50712/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}