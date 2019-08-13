using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.API.Models
{
    public class FriendList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FriendId { get; set; }
        public string AccountId { get; set; }
    }

    public class FriendListDto
    {
        public string FriendId { get; set; }
        public string AccountId { get; set; }
    }
}
