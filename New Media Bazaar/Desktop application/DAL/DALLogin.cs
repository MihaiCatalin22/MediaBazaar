using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Microsoft.Data.SqlClient;

namespace DAL_Library
{
    public class DALLogin : ILoginConttroller
    {
        public Login Checkadmin = new Login();
        private const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234;";
        
        public Login CheckLogin(string username, string password)
        {
            using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            {
                string query = @"SELECT * FROM User WHERE Username=@Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Checkadmin.Username = dr["Username"].ToString();
                            Checkadmin.Password = dr["Password"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            conn.Close();
            return Checkadmin;
            
        }
    }
}
