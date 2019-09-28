﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AllOrders;

namespace AllOrders
{

    public class Item
    {

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("finalPrice")]
        public string FinalPrice { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("isTaxAllowed")]
        public string IsTaxAllowed { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("shippingTimeInformation")]
        public string ShippingTimeInformation { get; set; }

        [JsonProperty("checkoutInformation")]
        public string CheckoutInformation { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("downloadInformation")]
        public IList<string> DownloadInformation { get; set; }

        [JsonProperty("addonValues")]
        public AddonValues AddonValues { get; set; }

        [JsonProperty("quantityUnitName")]
        public string QuantityUnitName { get; set; }

        [JsonProperty("gxCustomizerData")]
        public IList<string> GxCustomizerData { get; set; }
    }

}
