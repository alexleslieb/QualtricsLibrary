using QualtricsWebAPI.QualtricsClassLibrary.Routes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class Request
    {
        protected readonly string _baseUrl;
        protected readonly string _authorizationToken;

        protected Request(string baseUrl, string authorizationToken)
        {
            _baseUrl = baseUrl;
            _authorizationToken = authorizationToken;
        }

        protected async Task<(string, string)> SendQualtricsPostRequestAsync(string route, string jsonBody = "")
        {
            using (var client = new HttpClient())
            {
                // This would be the like http://www.uber.com
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Add("X-API-TOKEN", _authorizationToken);

                // serialize your json using newtonsoft json serializer then add it to the StringContent
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // method address would be like api/callUber:SomePort for example
                var result = await client.PostAsync(route, content);

                string resultContent = await result.Content.ReadAsStringAsync();

                return (resultContent ?? "", _baseUrl + route);
            }
        }

        protected async Task<(string, string)> SendQualtricsGetRequestAsync(string route, NameValueCollection? parameters = null)
        {
            using (var client = new HttpClient())
            {
                UriBuilder uriBuilder = new UriBuilder(_baseUrl + route);
                if (parameters?.Count > 0)
                {
                    string query = "?";
                    for(int i = 0; i < parameters.Count; i++)
                    {
                        query += (query != "?" ? "&" : "") + (parameters.GetKey(i) + "=" + parameters[i]);
                    }
                    uriBuilder.Query = query;
                }

                // This would be the like http://www.uber.com
                //client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Add("X-API-TOKEN", _authorizationToken);

                // method address would be like api/callUber:SomePort for example
                var result = await client.GetAsync(uriBuilder.Uri);

                string resultContent = await result.Content.ReadAsStringAsync();

                return (resultContent ?? "", uriBuilder.Uri.AbsoluteUri);
            }
        }

        protected async Task<(string, string)> SendQualtricsPutRequestAsync(string route, string jsonBody = "")
        {
            using (var client = new HttpClient())
            {
                // This would be the like http://www.uber.com
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Add("X-API-TOKEN", _authorizationToken);

                // serialize your json using newtonsoft json serializer then add it to the StringContent
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // method address would be like api/callUber:SomePort for example
                var result = await client.PutAsync(route, content);

                string resultContent = await result.Content.ReadAsStringAsync();

                return (resultContent ?? "", _baseUrl + route);
            }
        }

        protected async Task<(string, string)> SendQualtricsDeleteRequestAsync(string route)
        {
            using (var client = new HttpClient())
            {
                // This would be the like http://www.uber.com
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Add("X-API-TOKEN", _authorizationToken);

                // method address would be like api/callUber:SomePort for example
                var result = await client.DeleteAsync(route);

                string resultContent = await result.Content.ReadAsStringAsync();

                return (resultContent ?? "", _baseUrl + route) ;
            }
        }
    }
}
