using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.API.Models
{
    public class FriendList
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "friendid")]
        public string FriendId { get; set; }
        [JsonProperty(PropertyName = "accountid")]
        public string AccountId { get; set; }
    }

    public class FriendListDto
    {
        public string FriendId { get; set; }
        public string AccountId { get; set; }
    }
}
