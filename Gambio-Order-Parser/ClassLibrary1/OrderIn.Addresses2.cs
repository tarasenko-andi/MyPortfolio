﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClassLibrary
{

        public class Addresses2 : OrderIn
    {

            [JsonProperty("customer")]
            public Customer3 Customer { get; set; }

            [JsonProperty("billing")]
            public Billing2 Billing { get; set; }

            [JsonProperty("delivery")]
            public Delivery2 Delivery { get; set; }
        }

}