using Logic.Classes;
using Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALAnnoucement : BaseDAL, IAnnoucementController
    {
        public void AddAnnouncement(Announcement announcement)
        {
            using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
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

        public void UpdateAnnouncement(Announcement announcement)
        {
            using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            {
                string query = "UPDATE Announcements SET Title = @Title, Details= @Details , StartDate = @StartDate, EndDate = @EndDate WHERE id = @Id;";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Id", announcement.Id);
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
			using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
			{
				string query = @"SELECT * FROM Announcements";
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

							DateTime startDateDateTime = Convert.ToDateTime(dr["StartDate"]);
							DateOnly startDate = DateOnly.FromDateTime(startDateDateTime);

							DateTime endDateDateTime = Convert.ToDateTime(dr["EndDate"]);
							DateOnly endDate = DateOnly.FromDateTime(endDateDateTime);

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
			using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
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

							DateTime startDateDateTime = Convert.ToDateTime(dr["StartDate"]);
							DateOnly startDate = DateOnly.FromDateTime(startDateDateTime);

							DateTime endDateDateTime = Convert.ToDateTime(dr["EndDate"]);
							DateOnly endDate = DateOnly.FromDateTime(endDateDateTime);

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
        public Announcement[] GetAllCurrent()
        {
            try
            {
                List<Announcement> announcements = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM Announcements WHERE StartDate <= @daysBefore AND EndDate >= @today";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@daysBefore", DateTime.Now.AddDays(3));
                    cmd.Parameters.AddWithValue("@today", DateTime.Now);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[3]));
                        DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[4]));

                        announcements.Add(new Announcement
                        {
                            Id = reader.GetInt32("Id"),
                            Details = reader.GetString("Details"),
                            Title = reader.GetString("Title"),
                            StartDate = startDate,
                            EndDate = endDate,
                        });
                    }
                }
                return announcements.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
