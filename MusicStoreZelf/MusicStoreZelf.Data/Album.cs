using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Data
{
    public class Album
    {
        private int _albumId;
        private int _genreId;
        private int _artistId;
        private String _title;
        private decimal _price;
        private String _albumArtUrl;

        public int AlbumId
        {
            get { return _albumId; }
            set { _albumId = value; }
        }

        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        public int ArtistId
        {
            get { return _artistId; }
            set { _artistId = value; }
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public String AlbumArtUrl
        {
            get { return _albumArtUrl; }
            set { _albumArtUrl = value; }
        }






    }
}
