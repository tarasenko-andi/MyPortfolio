using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Customers
{
    public class AddonValues
    {
        public AddonValues(string[] test_key)
        {
            Test_key = test_key;
        }
        [JsonProperty("test_key")]
        [DataMember]
        public string[] Test_key { get; set; }
    }
}
