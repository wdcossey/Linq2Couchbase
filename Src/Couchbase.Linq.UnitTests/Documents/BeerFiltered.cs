using System;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    [Couchbase.Linq.Filters.DocumentTypeFilter("beer")]
    public class BeerFiltered
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abv")]
        public decimal Abv { get; set; }

        [JsonPropertyName("ibu")]
        public decimal Ibu { get; set; }

        [JsonPropertyName("srm")]
        public decimal Srm { get; set; }

        [JsonPropertyName("upc")]
        public decimal Upc { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("brewery_id")]
        public string BreweryId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }
    }
}
