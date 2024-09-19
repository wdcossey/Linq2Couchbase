using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    public class Geo
    {
        [JsonPropertyName("accuracy")]
        public virtual string Accuracy { get; set; }

        [JsonPropertyName("lat")]
        public virtual decimal Latitude { get; set; }

        [JsonPropertyName("lon")]
        public virtual decimal Longitude { get; set; }
    }
}
