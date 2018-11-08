using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Data
{
    public class AlbumRepository
    {
        public static List<Album> GetAlbumByGenre(int genreId)
        {
            String selectStatement = "SELECT * " +
                                     "FROM dbo.Album " +
                                     "WHERE GenreId = " + genreId + ";";

            SqlConnection connection = MusicStoreDb.GetConnection();

            SqlCommand command = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            var albums = new List<Album>();
            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                int albumIdOrdinal = reader.GetOrdinal("AlbumId");
                int genreIdOrdinal = reader.GetOrdinal("GenreId");
                int artistIdOrdinal = reader.GetOrdinal("ArtistId");
                int titleOrdinal = reader.GetOrdinal("Title");
                int priceOrdinal = reader.GetOrdinal("Price");
                int albumArtUrlOrdinal = reader.GetOrdinal("AlbumArtUrl");

                while(reader.Read())
                {
                    Album album = new Album()
                    {
                        AlbumId = reader.GetInt32(albumIdOrdinal),
                        GenreId = reader.GetInt32(genreIdOrdinal),
                        ArtistId = reader.GetInt32(artistIdOrdinal),
                        Title = reader.GetString(titleOrdinal),
                        Price = reader.GetDecimal(priceOrdinal),
                        AlbumArtUrl = reader.GetString(albumArtUrlOrdinal)
                    };
                    albums.Add(album);
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
            return albums;
        }
    }
}
