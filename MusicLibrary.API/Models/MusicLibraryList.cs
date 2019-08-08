using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.API.Models
{
    public class MusicLibraryList
    {
        public string ArtistName { get; set; }
        public string Album { get; set; }
        public List<SongInfo> Songs { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string AlbumCover { get; set; }
        public string ArtistPicture { get; set; }
    }

    public class SongInfo
    {
        public string Title { get; set; }
        public double Duration { get; set; }
    }
}
