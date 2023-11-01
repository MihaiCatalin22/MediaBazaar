using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using DAL;
using Microsoft.Data.SqlClient;

namespace DAL_Library
{
    public class DALLogin : BaseDAL, ILoginConttroller
    {
        public Login Checkadmin = new Login();       
        public Login CheckLogin(string username, string password)
        {
            using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            {
                string query = @"SELECT * FROM Employee WHERE Username=@Username";
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
                catch (SqlException sqlex)
                {
                    throw sqlex;
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
