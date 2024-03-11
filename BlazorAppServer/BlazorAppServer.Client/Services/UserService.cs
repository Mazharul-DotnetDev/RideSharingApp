using BlazorAppServer.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorAppServer.Client.Services
{
    public class UserService
    {
        private readonly HttpClient http;

        private string apiLink = "/api/Users";

        public UserService (HttpClient http, NavigationManager nav)
        {
            http.BaseAddress = new Uri(nav.BaseUri);
            this.http = http;
        }

        public async Task<IList<User>?> GetAll()
        {
            var data = await this.http.GetFromJsonAsync<IList<User>>(apiLink);
            return data;
        }
        public async Task<User?> GetById(int id)
        {
            return await this.http.GetFromJsonAsync<User>(apiLink + $"/{id}");
        }
        public async Task<HttpResponseMessage?> Save(User data)
        {
            return await this.http.PostAsJsonAsync<User>(apiLink, data);
        }
        public async Task<HttpResponseMessage?> Update(User data)
        {
            return await this.http.PutAsJsonAsync<User>(apiLink + $"/{data.UserId}", data);
        }

        public async Task<HttpResponseMessage?> Delete(int id)
        {
            return await this.http.DeleteAsync(apiLink + $"/{id}");
        }
    }
}
