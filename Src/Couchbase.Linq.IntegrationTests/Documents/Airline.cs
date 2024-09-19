using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    /*
     * {
          "id": 24,
          "type": "airline",
          "name": "American Airlines",
          "iata": "AA",
          "icao": "AAL",
          "callsign": "AMERICAN",
          "country": "United States"
        }
     * */
    public class Airline
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("iata")]
        public string Iata { get; set; }

        [JsonPropertyName("icao")]
        public string Icao { get; set; }

        [JsonPropertyName("callsign")]
        public string Callsign { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
