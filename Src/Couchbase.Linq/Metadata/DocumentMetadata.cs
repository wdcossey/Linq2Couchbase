using System.Text.Json;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.Metadata
{
    /// <summary>
    /// Metadata about a document in Couchbase
    /// </summary>
    public class DocumentMetadata
    {
        /// <summary>
        /// "Compare and swap" value.  This value changes each time the document is mutated.
        /// This can be used to ensure that the document has not been modified
        /// during a mutation, which enforces optimistic concurrency.
        /// </summary>
        [JsonPropertyName("cas")]
        public double Cas { get; set; }

        /// <summary>
        /// SDK specific flags.
        /// </summary>
        [JsonPropertyName("flags")]
        public int Flags { get; set; }

        /// <summary>
        /// Document's unique ID.  Also referred to as the document key.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Information about the type of the document.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

        /// <summary>
        /// Returns the JSON string representation of this object.
        /// </summary>
        /// <returns>JSON string representation of this object.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
