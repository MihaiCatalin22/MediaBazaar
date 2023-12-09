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
	public class DALRestockRequestsController : BaseDAL, IRestockRequestController
	{
		public bool CreateRestockRequest(string stockName, int quantity)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string sql = "UPDATE Stocks SET Quantity = Quantity + @quantity WHERE StockName = @stockName";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@stockName", stockName);
						cmd.Parameters.AddWithValue("@quantity", quantity);

						conn.Open();
						int result = cmd.ExecuteNonQuery();

						if (result < 0) return false;
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		public RestockRequest[] GetAllRestockRequests()
		{
			try
			{
				List<RestockRequest> requests = new List<RestockRequest>();
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string sql = "SELECT * FROM Stocks";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						conn.Open();
						SqlDataReader dr = cmd.ExecuteReader();

						while (dr.Read())
						{
							StockType parsedStockType;
							Enum.TryParse(dr["StockType"].ToString(), out parsedStockType);

							requests.Add(new RestockRequest
							{
								Id = Convert.ToInt32(dr["Id"]),
								StockName = dr["StockName"].ToString(),
								StockType = parsedStockType,
								Quantity = Convert.ToInt32(dr["Quantity"]),
								RequestDate = Convert.ToDateTime(dr["RequestDate"])
							});
						}
					}
				}
				return requests.ToArray();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		public RestockRequest GetRestockRequestById(int id)
		{
			try
			{
				RestockRequest request = null;
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string sql = "SELECT * FROM Stocks WHERE Id = @id";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@id", id);

						conn.Open();
						SqlDataReader dr = cmd.ExecuteReader();

						if (dr.Read())
						{
							StockType parsedStockType;
							Enum.TryParse(dr["StockType"].ToString(), out parsedStockType);

							request = new RestockRequest
							{
								Id = Convert.ToInt32(dr["Id"]),
								StockName = dr["StockName"].ToString(),
								StockType = parsedStockType,
								Quantity = Convert.ToInt32(dr["Quantity"]),
								RequestDate = Convert.ToDateTime(dr["RequestDate"])
							};
						}
					}
				}
				return request;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}
		public List<StockDetails> GetStockDetails()
		{
			List<StockDetails> stockDetails = new List<StockDetails>();
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					conn.Open();
					string query = "SELECT StockName, StockType, Quantity FROM Stocks";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								StockDetails details = new StockDetails
								{
									StockName = reader["StockName"].ToString(),
									StockType = (StockType)Enum.Parse(typeof(StockType), reader["StockType"].ToString()),
									Quantity = Convert.ToInt32(reader["Quantity"])
								};
								stockDetails.Add(details);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
					return null;
			}
			return stockDetails;
		}
		public List<StockDetails> GetStockDetailsByType(StockType stockType)
		{
			List<StockDetails> stockDetails = new List<StockDetails>();
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					conn.Open();
					string query = "SELECT StockName, StockType, Quantity FROM Stocks WHERE StockType = @stockType";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@stockType", stockType.ToString());

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								StockDetails detail = new StockDetails
								{
									StockName = reader["StockName"].ToString(),
									StockType = (StockType)Enum.Parse(typeof(StockType), reader["StockType"].ToString()),
									Quantity = Convert.ToInt32(reader["Quantity"])
								};
								stockDetails.Add(detail);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
			return stockDetails;
		}
		public List<string> GetStockNamesByType(StockType stockType)
		{
			List<string> stockNames = new List<string>();
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					conn.Open();
					string query = "SELECT StockName FROM Stocks WHERE StockType = @stockType";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@stockType", stockType.ToString());

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								stockNames.Add(reader["StockName"].ToString());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
			return stockNames;
		}
		public bool AddNewStock(string stockName, StockType stockType, int quantity)
		{
			try
			{
				using (var conn = new SqlConnection(CONNECTION_STRING))
				{
					string sql = "INSERT INTO Stocks (StockName, StockType, Quantity) VALUES (@stockName, @stockType, @quantity)";
					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@stockName", stockName);
						cmd.Parameters.AddWithValue("@stockType", stockType.ToString());
						cmd.Parameters.AddWithValue("@quantity", quantity);

						conn.Open();
						int result = cmd.ExecuteNonQuery();
						return result > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}

