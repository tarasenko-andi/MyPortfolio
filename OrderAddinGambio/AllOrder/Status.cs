﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AllOrders;

namespace AllOrders
{

    public class Status
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("isGuest")]
        public string IsGuest { get; set; }
    }

}
