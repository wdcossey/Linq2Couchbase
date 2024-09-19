using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    public class Schedule
    {
        [JsonPropertyName("day")]
        public uint Day { get; set; }

        [JsonPropertyName("utc")]
        public string Utc { get; set; }

        [JsonPropertyName("flight")]
        public string Flight { get; set; }
    }
}
