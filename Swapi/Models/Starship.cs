using Newtonsoft.Json;
using Swapi.Converters;
using System;

namespace Swapi.Models
{
    public class Starship
    {
        [JsonProperty("MGLT")]
        public string Mglt { get; set; }

        [JsonProperty("cargo_capacity")]
        public string CargoCapacity { get; set; }

        [JsonProperty("consumables")]
        public string Consumables { get; set; }

        [JsonProperty("cost_in_credits")]
        public string CostInCredits { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("crew")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Crew { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("hyperdrive_rating")]
        public string HyperdriveRating { get; set; }

        [JsonProperty("length")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Length { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("passengers")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Passengers { get; set; }

        [JsonProperty("films")]
        public Uri[] Films { get; set; }

        [JsonProperty("pilots")]
        public object[] Pilots { get; set; }

        [JsonProperty("starship_class")]
        public string StarshipClass { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
