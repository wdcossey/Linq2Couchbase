using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    public class Brewery
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("address")]
        public List<string> Address { get; set; }

        [JsonPropertyName("geo")]
        public Geo Geo { get; set; }

        /// <summary>
        /// Note: This property doesn't exist in the default beer-sample.  For tests we're acting as if it exists,
        /// and is a list of keys for all beers made by the brewery.
        /// </summary>
        [JsonPropertyName("beers")]
        public List<string> Beers { get; set; }
    }
}
