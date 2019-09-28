using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAddinGambio
{
    class OrderCheck
    {
        [JsonProperty("totalWeight")]
        public int TotalWeight { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("statusName")]
        public string StatusName { get; set; }

        [JsonProperty("totalSum")]
        public string TotalSum { get; set; }

        [JsonProperty("purchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("withdrawalIds")]
        public IList<object> WithdrawalIds { get; set; }

        [JsonProperty("mailStatus")]
        public bool MailStatus { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerStatusId")]
        public int CustomerStatusId { get; set; }

        [JsonProperty("customerStatusName")]
        public string CustomerStatusName { get; set; }

        [JsonProperty("customerMemos")]
        public IList<object> CustomerMemos { get; set; }

        [JsonProperty("deliveryAddress")]
        public DeliveryAddressClass DeliveryAddress { get; set; }

        [JsonProperty("billingAddress")]
        public BillingAddressClass BillingAddress { get; set; }

        [JsonProperty("paymentType")]
        public PaymentTypeClass PaymentType { get; set; }

        [JsonProperty("shippingType")]
        public ShippingTypeClass ShippingType { get; set; }

        [JsonProperty("trackingLinks")]
        public IList<object> TrackingLinks { get; set; }

        [JsonProperty("_links")]
        public LinksOrderClass LinksOrder { get; set; }

        public class BillingAddressClass
        {

            [JsonProperty("firstName")]
            public string FirstName { get; set; }

            [JsonProperty("lastName")]
            public string LastName { get; set; }

            [JsonProperty("company")]
            public string Company { get; set; }

            [JsonProperty("street")]
            public string Street { get; set; }

            [JsonProperty("houseNumber")]
            public string HouseNumber { get; set; }

            [JsonProperty("additionalAddressInfo")]
            public string AdditionalAddressInfo { get; set; }

            [JsonProperty("postcode")]
            public string Postcode { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("countryIsoCode")]
            public string CountryIsoCode { get; set; }
        }
        public class DeliveryAddressClass
        {

            [JsonProperty("firstName")]
            public string FirstName { get; set; }

            [JsonProperty("lastName")]
            public string LastName { get; set; }

            [JsonProperty("company")]
            public string Company { get; set; }

            [JsonProperty("street")]
            public string Street { get; set; }

            [JsonProperty("houseNumber")]
            public string HouseNumber { get; set; }

            [JsonProperty("additionalAddressInfo")]
            public string AdditionalAddressInfo { get; set; }

            [JsonProperty("postcode")]
            public string Postcode { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("countryIsoCode")]
            public string CountryIsoCode { get; set; }
        }
        public class LinksOrderClass
        {

            [JsonProperty("customer")]
            public string Customer { get; set; }
        }
        public class PaymentTypeClass
        {

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("module")]
            public string Module { get; set; }
        }
        public class ShippingTypeClass
        {

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("module")]
            public string Module { get; set; }
        }
    }
}
