using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Phine.SQL
{
    internal class MySQLClient
    {
        private String connectionString = "Server=myServerAddress;Port=1234;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
        private MySqlConnection client;

        public bool OpenSQLConnection()
        {
            try
            {
                client = new MySqlConnection();
                client.ConnectionString = connectionString;
                client.Open();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        public String GetVideoLocation()
        {
            return null;
        }

        public Video GetRandomUnseenVideo()
        {
            return null;
        }

        public Video GetVideoByID()
        {
            return null;
        }

        public bool VerifyLoginData(String username, String password)
        {
            return false;
        }

        public void SendLike(Video video, User user)
        {

        }

        public bool SendComment(Video video, Comment comment)
        {
            return false;
        }

        public User GetUserData(int userID)
        {
            return null;
        }
    }
}
