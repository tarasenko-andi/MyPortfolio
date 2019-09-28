using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AllOrders;
using ClassLibrary;
using System.Runtime.Serialization;

namespace AllOrders
{
    [DataContract]
    public class Attributes
    {
        public Attributes(long id, string name, string value, long price, string priceType, long optionId, long optionValueId, object combisId)
        {
            Id = id;
            Name = name;
            Value = value;
            Price = price;
            PriceType = priceType;
            OptionId = optionId;
            OptionValueId = optionValueId;
            CombisId = combisId;
        }
        [JsonProperty("id")]
        [DataMember]
        public long Id { get; set; }

        [JsonProperty("name")]
        [DataMember]
        public string Name { get; set; }

        [JsonProperty("value")]
        [DataMember]
        public string Value { get; set; }

        [JsonProperty("price")]
        [DataMember]
        public long Price { get; set; }

        [JsonProperty("priceType")]
        [DataMember]
        public string PriceType { get; set; }

        [JsonProperty("optionId")]
        [DataMember]
        public long OptionId { get; set; }

        [JsonProperty("optionValueId")]
        [DataMember]
        public long OptionValueId { get; set; }

        [JsonProperty("combisId")]
        [DataMember]
        public object CombisId { get; set; }
    }

}
