using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Business
{
    public class AlbumSummary
    {
        private String _title;
        private String _artist;
        private decimal _price;

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public String Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }



    }
}
