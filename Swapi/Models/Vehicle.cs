using Newtonsoft.Json;
using Swapi.Converters;
using System;

namespace Swapi.Models
{
    public class Vehicle
    {
        [JsonProperty("cargo_capacity")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CargoCapacity { get; set; }

        [JsonProperty("consumables")]
        public string Consumables { get; set; }

        [JsonProperty("cost_in_credits")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CostInCredits { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("crew")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Crew { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MaxAtmospheringSpeed { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("passengers")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Passengers { get; set; }

        [JsonProperty("pilots")]
        public object[] Pilots { get; set; }

        [JsonProperty("films")]
        public Uri[] Films { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("vehicle_class")]
        public string VehicleClass { get; set; }
    }
}
