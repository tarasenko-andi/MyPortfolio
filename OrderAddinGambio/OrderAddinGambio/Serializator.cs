using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OrderAddinGambio
{
    class Serializator
    {
        public static void serialize(object serobject, out string json)
        {
            json =
              JsonConvert.SerializeObject(
                serobject,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }
            );
        }
    }
}
