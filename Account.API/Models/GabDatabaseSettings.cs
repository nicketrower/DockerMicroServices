﻿using System;
namespace Account.API.Models
{
    public class GabDatabaseSettings: IGabDatabaseSettings
    {
        public string GabCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IGabDatabaseSettings
    {
        string GabCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    
}
