using AkaShop.ViewModel.System.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory httpClientFactory;

        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpconten = new StringContent(json, Encoding.UTF8, "application/json");
            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await  client.PostAsync("/api/users/authenticate", httpconten);
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }
    }
}
