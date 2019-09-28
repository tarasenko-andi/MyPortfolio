﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

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
    public class AddonValues
    {
        public AddonValues(long productId, long quantityUnitId/*, long identifier*/)
        {
            ProductId = productId;
            QuantityUnitId = quantityUnitId;
            //Identifier = identifier;
        }
        [DataMember]
        [JsonProperty("productId")]
        public long ProductId { get; set; }
        [DataMember]
        [JsonProperty("quantityUnitId")]
        public long QuantityUnitId { get; set; }
        //[DataMember]
        //[JsonProperty("identifier")]
        //public long Identifier { get; set; }
    }

}