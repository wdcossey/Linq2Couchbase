using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    [Filters.DocumentTypeFilter("beer")]
    public class BeerFiltered
    {
        [JsonPropertyName("name")]
        public virtual string Name { get; set; }

        [JsonPropertyName("abv")]
        public virtual decimal Abv { get; set; }

        [JsonPropertyName("ibu")]
        public virtual decimal Ibu { get; set; }

        [JsonPropertyName("srm")]
        public decimal Srm { get; set; }

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

        [Key]
        public string Key { get { return BreweryId + "-" + Name.ToLower().Replace(' ', '_'); } }
    }
}
