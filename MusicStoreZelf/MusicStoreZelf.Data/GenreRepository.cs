using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Data
{
    public class GenreRepository
    {
        public static List<Genre> GetGenres()
        {
            String selectStatement = "SELECT genreId, name, description " +
                                     "FROM dbo.Genre";

            SqlConnection connection = MusicStoreDb.GetConnection();

            SqlCommand command = new SqlCommand(selectStatement, connection);

            SqlDataReader reader = null;

            var genres = new List<Genre>();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                int genreIdOrdinal = reader.GetOrdinal("GenreId");
                int genreName = reader.GetOrdinal("Name");
                int description = reader.GetOrdinal("Description");

                while(reader.Read())
                {
                    Genre genre = new Genre()
                    {
                        GenreId = reader.GetInt32(genreIdOrdinal),
                        Name = reader.GetString(genreName),
                        Description = reader.GetString(description)
                    };

                    genres.Add(genre);
                }
            }
            finally
            {
                if(reader != null)
                {
                    reader = null;
                }
                connection.Close();
            }
            return genres;
        }
    }
}
