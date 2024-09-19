using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.UnitTests.Documents
{
    class Address
    {
        [JsonPropertyName("address1")]
        public string AddressLine1 { get; set; }
    }
}
