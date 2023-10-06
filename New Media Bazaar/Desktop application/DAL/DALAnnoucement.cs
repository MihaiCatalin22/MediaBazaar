using Logic.Classes;
using Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALAnnoucement : IAnnoucementController
    {
        private CreateConnection createConnection;

        public DALAnnoucement(CreateConnection createConnection)
        {
            this.createConnection = createConnection;

        }

        public void AddAnnouncement(Announcement announcement)
        {
            using (SqlConnection conn = createConnection.Connection())
            {
                string query = "INSERT INTO Announcements (Title, Details, StartDate, EndDate) VALUES (@Title, @Details, @StartDate, @EndDate);";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Title", announcement.Title);
                    cmd.Parameters.AddWithValue("@Details", announcement.Details);
                    cmd.Parameters.AddWithValue("@StartDate", announcement.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", announcement.EndDate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception e)
                {
                    conn.Close();
                }

            }
        }

        public Announcement EditAnnouncement(Announcement announcement)
        {
            throw new NotImplementedException();
        }

        public Announcement[] GetAllAnnouncements()
        {
            List<Announcement> list = new List<Announcement>();
            using SqlConnection conn = createConnection.Connection();
            {
                string query = @"SELECT * FROM Announcements ";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr["Id"]);
                            string title = dr["Title"].ToString();
                            string details = dr["Details"].ToString();
                            DateTime startDate = DateTime.Parse(dr["StartDate"].ToString());
                            DateTime endDate = DateTime.Parse(dr["EndDate"].ToString());

                            Announcement allAnnouncement = new Announcement(id, title, details, startDate, endDate);
                            list.Add(allAnnouncement);
                        }
                    }
                    conn.Close();
                }
                catch (SqlException sqlex)
                {
                    throw sqlex;
                }

            }

            return list.ToArray();
        }

        public Announcement GetAnnouncement(int id)
        {
            Announcement getAnnouncement = new Announcement();
            using SqlConnection conn = createConnection.Connection();
            {
                string query = @"SELECT * FROM Announcements WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string title = dr["Title"].ToString();
                            string details = dr["Details"].ToString();
                            DateTime startDate = DateTime.Parse(dr["StartDate"].ToString());
                            DateTime endDate = DateTime.Parse(dr["EndDate"].ToString());

                            getAnnouncement = new Announcement(id, title, details, startDate, endDate);
                        }
                    }
                    conn.Close();
                }
                catch (SqlException sqlex)
                {
                    throw sqlex;
                }
                return getAnnouncement;
            }
        }
        public void RemoveAnnouncement(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}
