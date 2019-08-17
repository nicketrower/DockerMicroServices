using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Account.API.Models
{
    public class AccountInfo
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "emailaddress")]
        public string EmailAddress { get; set; }
        [JsonProperty(PropertyName = "phonenumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty(PropertyName = "isActive")]
        public bool AccountStatus { get; set; }
    }

    public class AccountInfoDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public bool AccountStatus { get; set; }
    }
}
