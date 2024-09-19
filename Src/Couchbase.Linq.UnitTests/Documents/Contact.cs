using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    public sealed class Contact
    {
        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("fname")]
        public string FirstName { get; set; }

        [JsonPropertyName("lname")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("hobbies")]
        public List<string> Hobbies { get; set; }

        [JsonPropertyName("relation")]
        public string Relation { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }
    }


    /*
     *    {
      "age": 46,
      "children": [
        {
          "age": 17,
          "fname": "Aiden",
          "gender": "m"
        },
        {
          "age": 2,
          "fname": "Bill",
          "gender": "f"
        }
      ],
      "email": "dave@gmail.com",
      "fname": "Dave",
      "hobbies": [
        "golf",
        "surfing"
      ],
      "lname": "Smith",
      "relation": "friend",
      "title": "Mr.",
      "type": "contact"
    },*/
}
