using System.Collections.Generic;
using Newtonsoft.Json;
using AllOrders;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract]
    public class Order
    {

        [DataMember]
        [JsonProperty("id")]
        public long Id { get; set; }

        [DataMember]
        [JsonProperty("statusId")]
        public long StatusId { get; set; }

        [DataMember]
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }

        [JsonProperty("currencyCode")]
        [DataMember]
        public string CurrencyCode { get; set; }

        [JsonProperty("languageCode")]
        [DataMember]
        public string LanguageCode { get; set; }

        [JsonProperty("comment")]
        [DataMember]
        public string Comment { get; set; }

        [JsonProperty("totalWeight")]
        [DataMember]
        public long TotalWeight { get; set; }

        [JsonProperty("paymentType")]
        [DataMember]
        public PaymentType PaymentType { get; set; }

        [JsonProperty("shippingType")]
        [DataMember]
        public ShippingType ShippingType { get; set; }

        [JsonProperty("customer")]
        [DataMember]
        public Customer Customer { get; set; }

        [JsonProperty("addresses")]
        [DataMember]
        public Addresses Addresses { get; set; }

        [JsonProperty("items")]
        [DataMember]
        public IList<Item> Items { get; set; }

        [JsonProperty("totals")]
        [DataMember]
        public IList<Total> Totals { get; set; }

        [JsonProperty("statusHistory")]
        [DataMember]
        public IList<StatusHistory> StatusHistory { get; set; }

        [JsonProperty("addonValues")]
        [DataMember]
        public AddonValues2[] AddonValues { get; set; }
        public Order(
            long id,
            long statusId,
            string purchaseDate,
            string currencyCode,
            string languageCode,
            long totalWeight,
            string comment,
            PaymentType paymentType,
            ShippingType shippingType,
            Customer customer,
            Addresses addresses,
            IList<Item> items,
            IList<Total> totals,
            IList<StatusHistory> statusHistory,
            AddonValues2[] addonValues)
        {
            Id = id;
            StatusId = statusId;
            PurchaseDate = purchaseDate;
            CurrencyCode = currencyCode;
            LanguageCode = languageCode;
            Comment = comment;
            TotalWeight = totalWeight;
            PaymentType = paymentType;
            ShippingType = shippingType;
            Customer = customer;
            Addresses = addresses;
            Items = items;
            Totals = totals;
            StatusHistory = statusHistory;
            AddonValues = addonValues;
        }
        public Order()
        {
        }
    }
}
