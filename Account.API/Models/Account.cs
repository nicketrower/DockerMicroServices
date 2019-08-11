﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Account.API.Models
{
    public class AccountInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int AccountStatus { get; set; }
    }
}
