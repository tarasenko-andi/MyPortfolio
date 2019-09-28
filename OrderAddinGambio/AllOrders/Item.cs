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
    public class Item
    {
        public Item(long id, string model, string name, long quantity, long price, long finalPrice, long tax, bool isTaxAllowed, long discount, string shippingTimeInformation,
            string checkoutInformation, Attributes attributes, DownloadInformation downloadInformation, AddonValues[] addonValues, string quantityUnitName)
        {
            Id = id;
            Model = model;
            Name = name;
            Quantity = quantity;
            Price = price;
            Tax = tax;
            IsTaxAllowed = isTaxAllowed;
            Discount = discount;
            ShippingTimeInformation = shippingTimeInformation;
            CheckoutInformation = checkoutInformation;
            QuantityUnitName = quantityUnitName;
            Attributes = attributes;
            FinalPrice = finalPrice;
            DownloadInformation = downloadInformation;
            AddonValues = addonValues;
            //GxCustomizerData = gxCustomizerData;
        }
        [JsonProperty("id")]
        [DataMember]
        public long Id { get; set; }

        [JsonProperty("model")]
        [DataMember]
        public string Model { get; set; }

        [JsonProperty("name")]
        [DataMember]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        [DataMember]
        public long Quantity { get; set; }

        [JsonProperty("price")]
        [DataMember]
        public long Price { get; set; }

        [JsonProperty("finalPrice")]
        [DataMember]
        public long FinalPrice { get; set; }

        [JsonProperty("tax")]
        [DataMember]
        public long Tax { get; set; }

        [JsonProperty("isTaxAllowed")]
        [DataMember]
        public bool IsTaxAllowed { get; set; }

        [JsonProperty("discount")]
        [DataMember]
        public long Discount { get; set; }

        [JsonProperty("shippingTimeInformation")]
        [DataMember]
        public string ShippingTimeInformation { get; set; }

        [JsonProperty("checkoutInformation")]
        [DataMember]
        public string CheckoutInformation { get; set; }

        [JsonProperty("attributes")]
        [DataMember]
        public Attributes Attributes { get; set; }

        [JsonProperty("downloadInformation")]
        [DataMember]
        public DownloadInformation DownloadInformation { get; set; }

        [JsonProperty("addonValues")]
        [DataMember]
        public AddonValues[] AddonValues { get; set; }

        [JsonProperty("quantityUnitName")]
        [DataMember]
        public string QuantityUnitName { get; set; }

        //[JsonProperty("gxCustomizerData")]
        //[DataMember]
        //public IList<string> GxCustomizerData { get; set; }
    }

}
