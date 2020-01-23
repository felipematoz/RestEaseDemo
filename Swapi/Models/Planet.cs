using Newtonsoft.Json;
using Swapi.Converters;
using System;

namespace Swapi.Models
{
    public class Planet
    {
        [JsonProperty("climate")]
        public string Climate { get; set; }

        [JsonProperty("diameter")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Diameter { get; set; }

        [JsonProperty("gravity")]
        public string Gravity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orbital_period")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long OrbitalPeriod { get; set; }

        [JsonProperty("population")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Population { get; set; }

        [JsonProperty("residents")]
        public Uri[] Residents { get; set; }

        [JsonProperty("rotation_period")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long RotationPeriod { get; set; }

        [JsonProperty("surface_water")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SurfaceWater { get; set; }

        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
