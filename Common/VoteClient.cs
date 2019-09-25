using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VoteWebApp.Common
{
    public class VoteClient
    {
        public HttpClient client { get; private set; }
        public VoteClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("http://localhost:3011");
            client = httpClient;
        }
        public async Task<IEnumerable<string>> LoadData()
        {
            var response = await client.GetAsync("/api/home");
            var content = await response.Content.ReadAsAsync<IEnumerable<string>>();
            return content;
        }
    }
}
