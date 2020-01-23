using Newtonsoft.Json;
using System;

namespace Swapi.Models
{
    public class Film
    {
        [JsonProperty("characters")]
        public Uri[] Characters { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("episode_id")]
        public long EpisodeId { get; set; }

        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }

        [JsonProperty("planets")]
        public Uri[] Planets { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("species")]
        public Uri[] Species { get; set; }

        [JsonProperty("starships")]
        public Uri[] Starships { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("vehicles")]
        public Uri[] Vehicles { get; set; }
    }
}
