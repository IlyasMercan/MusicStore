using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Data
{
    public class ArtistRepository
    {
        public static String GetArtistNameById(int artistId)
        {
            String selectStatement = "SELECT * " +
                                     "FROM dbo.Artist " +
                                     "WHERE ArtistId = " + artistId + ";";
            SqlConnection connection = MusicStoreDb.GetConnection();

            SqlCommand command = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            Artist artist = new Artist();
            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                int artistIdOrdinal = reader.GetOrdinal("ArtistId");
                int nameOrdinal = reader.GetOrdinal("Name");

                while(reader.Read())
                {
                    Artist temporaryArtist = new Artist()
                    {
                        ArtistId = reader.GetInt32(artistIdOrdinal),
                        Name = reader.GetString(nameOrdinal)
                    };

                    artist = temporaryArtist;
                }
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                connection.Close();
            }
            return artist.Name;
            
        }
    }
}
