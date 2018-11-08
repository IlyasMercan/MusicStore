using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Data
{
    public class Artist
    {
        private int _artistId;
        private String _name;

        public int ArtistId
        {
            get { return _artistId; }
            set { _artistId = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
