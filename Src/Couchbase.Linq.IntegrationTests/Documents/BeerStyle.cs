using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Couchbase.Linq.IntegrationTests.Documents
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BeerStyle
    {
        Porter,

        [EnumMember(Value="Oatmeal Stout")]
        OatmealStout,

        [EnumMember(Value="Pumpkin Beer")]
        PumpkinBeer
    }
}
