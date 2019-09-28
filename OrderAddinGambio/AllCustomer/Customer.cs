using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Customers
{
    [DataContract]
    public class Customer
    {
        public Customer(IList<AddonValues> addonValues,Address address, string dateOfBirth, object email, string fax, string firstname, string gender,
            bool isGuest, string lastname, string number, string password, string statusId, string telephone, string type, string vatNumber,
            long vatNumberStatus)
        {
            AddonValues = addonValues;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
            Fax = fax;
            Firstname = firstname;
            Gender = gender;
            IsGuest = isGuest;
            Lastname = lastname;
            Number = number;
            Password = password;
            StatusId = statusId;
            Telephone = telephone;
            Type = type;
            VatNumber = vatNumber;
            VatNumberStatus = vatNumberStatus;
        }
        [JsonProperty("addonValues")]
        [DataMember]
        public IList<AddonValues> AddonValues { get; set; }

        [JsonProperty("address")]
        [DataMember]
        public Address Address { get; set; }

        [JsonProperty("dateOfBirth")]
        [DataMember]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        [DataMember]
        public object Email { get; set; }

        [JsonProperty("fax")]
        [DataMember]
        public string Fax { get; set; }

        [JsonProperty("firstname")]
        [DataMember]
        public string Firstname { get; set; }

        [JsonProperty("gender")]
        [DataMember]
        public string Gender { get; set; }

        [JsonProperty("isGuest")]
        [DataMember]
        public bool IsGuest { get; set; }

        [JsonProperty("lastname")]
        [DataMember]
        public string Lastname { get; set; }

        [JsonProperty("number")]
        [DataMember]
        public string Number { get; set; }

        [JsonProperty("password")]
        [DataMember]
        public string Password { get; set; }

        [JsonProperty("statusId")]
        [DataMember]
        public string StatusId { get; set; }

        [JsonProperty("telephone")]
        [DataMember]
        public string Telephone { get; set; }

        [JsonProperty("type")]
        [DataMember]
        public string Type { get; set; }

        [JsonProperty("vatNumber")]
        [DataMember]
        public string VatNumber { get; set; }

        [JsonProperty("vatNumberStatus")]
        [DataMember]
        public long VatNumberStatus { get; set; }
    }

}
