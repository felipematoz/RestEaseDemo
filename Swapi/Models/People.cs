﻿using Newtonsoft.Json;
using Swapi.Converters;
using System;

namespace Swapi.Models
{
    public class People
    {
        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("films")]
        public Uri[] Films { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("height")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Height { get; set; }

        [JsonProperty("homeworld")]
        public Uri Homeworld { get; set; }

        [JsonProperty("mass")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Mass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("species")]
        public Uri[] Species { get; set; }

        [JsonProperty("starships")]
        public Uri[] Starships { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("vehicles")]
        public Uri[] Vehicles { get; set; }
    }
}
