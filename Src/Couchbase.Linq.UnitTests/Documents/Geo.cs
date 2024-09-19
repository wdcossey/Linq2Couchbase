using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    public class Geo
    {
        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; }

        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }

        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
    }
}
