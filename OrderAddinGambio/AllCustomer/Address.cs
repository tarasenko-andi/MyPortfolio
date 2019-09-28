using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Customers
{
    [DataContract]
    public class Address
    {
        public Address(string additionalAddressInfo, bool b2bStatus, string city, string company, string countryId, string houseNumber, string postcode,
            string street, string suburb, string zoneId)
        {
            AdditionalAddressInfo = additionalAddressInfo;
            B2bStatus = b2bStatus;
            City = city;
            Company = company;
            CountryId = countryId;
            HouseNumber = houseNumber;
            Postcode = postcode;
            Street = street;
            Suburb = suburb;
            ZoneId = zoneId;
        }

        [JsonProperty("additionalAddressInfo")]
        [DataMember]
        public string AdditionalAddressInfo { get; set; }

        [JsonProperty("b2bStatus")]
        [DataMember]
        public bool B2bStatus { get; set; }

        [JsonProperty("city")]
        [DataMember]
        public string City { get; set; }

        [JsonProperty("company")]
        [DataMember]
        public string Company { get; set; }

        [JsonProperty("countryId")]
        [DataMember]
        public string CountryId { get; set; }

        [JsonProperty("houseNumber")]
        [DataMember]
        public string HouseNumber { get; set; }

        [JsonProperty("postcode")]
        [DataMember]
        public string Postcode { get; set; }

        [JsonProperty("street")]
        [DataMember]
        public string Street { get; set; }

        [JsonProperty("suburb")]
        [DataMember]
        public string Suburb { get; set; }

        [JsonProperty("zoneId")]
        [DataMember]
        public string ZoneId { get; set; }
    }

}
