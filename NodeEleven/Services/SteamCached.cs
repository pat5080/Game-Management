using System.Threading.Tasks;
using System.Net.Http;

namespace NodeEleven.Services.Steam
{
    public class SteamCached : SteamService
    {
        public SteamCached(HttpClient httpClient) : base(httpClient)
        {
        }

        public override async Task InitializeAsync()
        {
            await GetPostsAsync();
        }
    }
}
