using MySql.Data.MySqlClient;

namespace DAO.DataLayer
{
    internal class ConnectionDb
    {
        public static MySqlConnection Connect()
        {
            MySqlConnection conn = null;
            var connectionStr = @"server=localhost;port=3306;userid=root;password=;database=booking";
            try
            {
                conn = new MySqlConnection(connectionStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                ex.GetBaseException();
            }

            return conn;
        }
    }
}