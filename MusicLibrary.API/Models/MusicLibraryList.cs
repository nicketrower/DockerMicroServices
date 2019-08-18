using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.API.Models
{
    public class MusicLibraryList
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "accountid")]
        public string AccountId { get; set; }

        [JsonProperty(PropertyName = "artistname")]
        public string ArtistName { get; set; }

        [JsonProperty(PropertyName = "album")]
        public string Album { get; set; }

        [JsonProperty(PropertyName = "songs")]
        public List<SongInfo> Songs { get; set; }

        [JsonProperty(PropertyName = "releasedate")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "albumcover")]
        public string AlbumCover { get; set; }

        [JsonProperty(PropertyName = "artistpicture")]
        public string ArtistPicture { get; set; }
    }

    public class SongInfo
    {
        public string Title { get; set; }
        public double Duration { get; set; }
    }

    public class MusicLibraryListDto
    {
        public string AccountId { get; set; }
        public string ArtistName { get; set; }
        public string Album { get; set; }
        public List<SongInfo> Songs { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string AlbumCover { get; set; }
        public string ArtistPicture { get; set; }
    }
}
