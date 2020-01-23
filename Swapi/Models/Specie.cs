using Newtonsoft.Json;
using Swapi.Converters;
using System;

namespace Swapi.Models
{
    public class Specie
    {
        [JsonProperty("average_height")]
        public string AverageHeight { get; set; }

        [JsonProperty("average_lifespan")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AverageLifespan { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("eye_colors")]
        public string EyeColors { get; set; }

        [JsonProperty("hair_colors")]
        public string HairColors { get; set; }

        [JsonProperty("homeworld")]
        public Uri Homeworld { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("people")]
        public Uri[] People { get; set; }

        [JsonProperty("films")]
        public Uri[] Films { get; set; }

        [JsonProperty("skin_colors")]
        public string SkinColors { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
