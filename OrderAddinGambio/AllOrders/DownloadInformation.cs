using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AllOrders
{
    [DataContract]
    public class DownloadInformation
    {
        public DownloadInformation(long countAvailable, string filename, long maxDaysAllowed)
        {
            CountAvailable = countAvailable;
            Filename = filename;
            MaxDaysAllowed = maxDaysAllowed;
        }
        [JsonProperty("countAvailable")]
        [DataMember]
        public long CountAvailable { get; set; }
        [DataMember]
        [JsonProperty("filename")]
        public string Filename { get; set; }
        [DataMember]
        [JsonProperty("maxDaysAllowed")]
        public long MaxDaysAllowed { get; set; }
    }
}
