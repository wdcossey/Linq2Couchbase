using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    public class Airport
    {
        [Key]
        [JsonPropertyName("id")]
        public virtual int Id { get; set; }

        [JsonPropertyName("airportname")]
        public virtual string AirportName { get; set; }

        [JsonPropertyName("faa")]
        public virtual string Faa { get; set; }

        [JsonPropertyName("type")]
        public virtual string Type { get; set; }
    }
}
