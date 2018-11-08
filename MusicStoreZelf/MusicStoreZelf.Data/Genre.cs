using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Data
{
    public class Genre
    {
        private int _genreId;
        private String _name;
        private String _description;

        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }



    }
}
