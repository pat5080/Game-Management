namespace NodeEleven.Services.Steam
{
    public class SteamSettings
    {
        public static string SiteLocation { get; } = "http://api.steampowered.com/";

        public static string RestApiLocation { get; } = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=440&count=3&maxlength=300&format=json";

    }
}
