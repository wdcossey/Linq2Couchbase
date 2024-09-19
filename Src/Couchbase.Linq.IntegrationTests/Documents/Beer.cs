using System;
using Couchbase.Core.IO.Serializers;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    public class Beer
    {
        [JsonPropertyName("name")]
        public virtual string Name { get; set; }

        [JsonPropertyName("abv")]
        public virtual decimal Abv { get; set; }

        [JsonPropertyName("ibu")]
        public virtual decimal Ibu { get; set; }

        [JsonPropertyName("srm")]
        public virtual decimal Srm { get; set; }

        [JsonPropertyName("upc")]
        public virtual decimal Upc { get; set; }

        [JsonPropertyName("type")]
        public virtual string Type { get; set; }

        [JsonPropertyName("brewery_id")]
        public virtual string BreweryId { get; set; }

        [JsonPropertyName("description")]
        public virtual string Description { get; set; }

        [JsonPropertyName("style")]
        public virtual string Style { get; set; }

        [JsonPropertyName("category")]
        public virtual string Category { get; set; }

        [JsonPropertyName("updated")]
        public virtual DateTime Updated { get; set; }

        [JsonPropertyName("updated_offset")]
        public virtual DateTimeOffset UpdatedOffset { get; set; }

        // This property isn't normally on beers in the beer-sample bucket
        // But we need it for some integration tests so we'll add it
        [JsonPropertyName("updatedUnixMillis")]
        [JsonConverter(typeof(UnixMillisecondsConverter))]
        public virtual DateTime? UpdatedUnixMillis { get; set; }
    }
}
