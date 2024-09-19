using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    public class Route
    {
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("airline")]
        public string Airline { get; set; }

        [JsonPropertyName("airlineid")]
        public string AirlineId { get; set; }

        [JsonPropertyName("sourceairport")]
        public string SourceAirport { get; set; }

        [JsonPropertyName("destinationairport")]
        public string DestinationAirport { get; set; }

        [JsonPropertyName("stops")]
        public uint Stops { get; set; }

        [JsonPropertyName("equipment")]
        public string Equipment { get; set; }

        [JsonPropertyName("schedule")]
        public List<Schedule> Schedule { get; set; }
    }
 }
