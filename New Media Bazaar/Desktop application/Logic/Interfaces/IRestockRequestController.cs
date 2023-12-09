using Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
	public interface IRestockRequestController
	{
		bool CreateRestockRequest(string stockName, int quantity);
		RestockRequest[] GetAllRestockRequests();
		RestockRequest GetRestockRequestById(int id);
		List<StockDetails> GetStockDetails();
		List<StockDetails> GetStockDetailsByType(StockType stockType);
		List<string> GetStockNamesByType(StockType stockType);
		bool AddNewStock(string stockName, StockType stockType, int quantity);
	}
}
