﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ClassLibrary
{

        public class StatusHistory2 : OrderIn
        {

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("statusId")]
            public int StatusId { get; set; }

            [JsonProperty("dateAdded")]
            public string DateAdded { get; set; }

            [JsonProperty("comment")]
            public string Comment { get; set; }

            [JsonProperty("customerNotified")]
            public bool CustomerNotified { get; set; }
        }

}