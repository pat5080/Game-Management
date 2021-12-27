using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using NodeEleven.Models.SteamModel;

namespace NodeEleven.Services.Steam
{
    public class SteamService
    {
        private HttpClient _httpClient;

        public SteamService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Credentials", "true");
            _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Headers", "Access-Control-Allow-Origin,Content-Type");
        }

        public string GetBaseUrl()
        {
            return _httpClient.BaseAddress.ToString();
        }

        public virtual async Task InitializeAsync()
        {
            await Task.Run(() => null);
        }

        public virtual async Task<appnews> GetPostsAsync()
        {

            return await _httpClient.GetFromJsonAsync<appnews>($"/ISteamNews/GetNewsForApp/v0002/?appid=440&count=3&maxlength=300&format=json");
        }
    }
}
