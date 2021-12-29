using System.Text.Json.Serialization;


namespace NodeEleven.Models.SteamModel


{
    public class SteamModel
    {
        [JsonPropertyName("appnews")]
        public appnews appnews { get; set; }
    }

    public class appnews
    {
        [JsonPropertyName("appid")]
        public int appid { get; set; }

        [JsonPropertyName("newsitems")]
        public Newsitem[] newsitems { get; set; }

        [JsonPropertyName("count")]
        public int count { get; set; }
    }

    public class Newsitem
    {
        [JsonPropertyName("gid")]
        public string gid { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("is_external_url")]
        public bool is_external_url { get; set; }

        [JsonPropertyName("author")]
        public string author { get; set; }

        [JsonPropertyName("contents")]
        public string contents { get; set; }

        [JsonPropertyName("feedlabel")]
        public string feedlabel { get; set; }

        [JsonPropertyName("date")]
        public int date { get; set; }

        [JsonPropertyName("feedname")]
        public string feedname { get; set; }

        [JsonPropertyName("feed_type")]
        public int feed_type { get; set; }

        [JsonPropertyName("appid")]
        public int appid { get; set; }

        [JsonPropertyName("tags")]
        public string[] tags { get; set; }
    }

}
