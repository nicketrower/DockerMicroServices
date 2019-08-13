using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB.Common
{
    public class GabDatabaseSettings : IGabDatabaseSettings
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
