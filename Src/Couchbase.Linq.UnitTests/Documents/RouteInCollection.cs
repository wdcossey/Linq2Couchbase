using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    [CouchbaseCollection("inventory", "route")]
    public class RouteInCollection
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

    /*{
  "id": 5966,
  "type": "route",
  "airline": "AA",
  "airlineid": "airline_24",
  "sourceairport": "MCO",
  "destinationairport": "SEA",
  "stops": 0,
  "equipment": "737",
  "schedule": [
    {
      "day": 0,
      "utc": "22:03:00",
      "flight": "AA138"
    },
    {
      "day": 0,
      "utc": "17:57:00",
      "flight": "AA809"
    },
    {
      "day": 1,
      "utc": "14:29:00",
      "flight": "AA544"
    },
    {
      "day": 2,
      "utc": "03:34:00",
      "flight": "AA188"
    },
    {
      "day": 2,
      "utc": "13:01:00",
      "flight": "AA932"
    },
    {
      "day": 2,
      "utc": "10:14:00",
      "flight": "AA491"
    },
    {
      "day": 2,
      "utc": "23:25:00",
      "flight": "AA819"
    },
    {
      "day": 3,
      "utc": "14:27:00",
      "flight": "AA107"
    },
    {
      "day": 3,
      "utc": "02:40:00",
      "flight": "AA494"
    },
    {
      "day": 3,
      "utc": "03:14:00",
      "flight": "AA768"
    },
    {
      "day": 3,
      "utc": "01:17:00",
      "flight": "AA719"
    },
    {
      "day": 3,
      "utc": "06:00:00",
      "flight": "AA349"
    },
    {
      "day": 4,
      "utc": "00:37:00",
      "flight": "AA096"
    },
    {
      "day": 4,
      "utc": "19:00:00",
      "flight": "AA162"
    },
    {
      "day": 5,
      "utc": "23:57:00",
      "flight": "AA346"
    },
    {
      "day": 5,
      "utc": "11:23:00",
      "flight": "AA871"
    },
    {
      "day": 6,
      "utc": "15:07:00",
      "flight": "AA951"
    },
    {
      "day": 6,
      "utc": "07:02:00",
      "flight": "AA093"
    },
    {
      "day": 6,
      "utc": "19:29:00",
      "flight": "AA558"
    },
    {
      "day": 6,
      "utc": "21:59:00",
      "flight": "AA147"
    },
    {
      "day": 6,
      "utc": "17:13:00",
      "flight": "AA262"
    }
  ]
}*/
}
