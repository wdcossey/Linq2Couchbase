
using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
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

    /*"day": 0,
      "utc": "22:03:00",
      "flight": "AA138"
     * */
}
