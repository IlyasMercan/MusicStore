using System.Configuration;
using System.Data.SqlClient;

namespace MusicStoreZelf.Data
{
    public class MusicStoreDb
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MusicStoreConnection"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
