using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    public class Brewery
    {
        [JsonPropertyName("name")]
        public virtual string Name { get; set; }

        [JsonPropertyName("city")]
        public virtual string City { get; set; }

        [JsonPropertyName("state")]
        public virtual string State { get; set; }

        [JsonPropertyName("code")]
        public virtual string Code { get; set; }

        [JsonPropertyName("country")]
        public virtual string Country { get; set; }

        [JsonPropertyName("phone")]
        public virtual string Phone { get; set; }

        [JsonPropertyName("website")]
        public virtual string Website { get; set; }

        [JsonPropertyName("type")]
        public virtual string Type { get; set; }

        [JsonPropertyName("updated")]
        public virtual DateTime Updated { get; set; }

        [JsonPropertyName("description")]
        public virtual string Description { get; set; }

        [JsonPropertyName("address")]
        public virtual IList<string> Address { get; set; }

        [JsonPropertyName("geo")]
        public virtual Geo Geo { get; set; }

        /// <summary>
        /// Note: This property doesn't exist in the default beer-sample.  For tests we're acting as if it exists,
        /// and is a list of keys for all beers made by the brewery.
        /// </summary>
        [JsonPropertyName("beers")]
        public virtual IList<string> Beers { get; set; }
    }
}
