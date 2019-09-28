﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AllOrders;

namespace AllOrders
{

    public class Billing
    {

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("additionalAddressInfo")]
        public string AdditionalAddressInfo { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryId")]
        public string CountryId { get; set; }

        [JsonProperty("zoneId")]
        public string ZoneId { get; set; }

        [JsonProperty("b2bStatus")]
        public string B2bStatus { get; set; }
    }

}
