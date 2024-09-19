using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    public sealed class Child
    {
        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("fname")]
        public string FirstName { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("contactId")]
        public string ContactId { get; set; }
    }
}
