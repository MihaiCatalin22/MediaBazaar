using Logic.Interfaces;
using Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Logic.Controllers
{
	public class RestockRequestController
	{
		private IRestockRequestController restockRequestManager;

		public RestockRequestController(IRestockRequestController manager)
		{
			restockRequestManager = manager;
		}

		public bool CreateRestockRequest(string stockName, int quantity)
		{
			return restockRequestManager.CreateRestockRequest(stockName, quantity);
		}
		public RestockRequest[] ViewAllRestockRequests()
		{
			return restockRequestManager.GetAllRestockRequests();
		}
		public List<StockDetails> GetStockDetails()
		{
			return restockRequestManager.GetStockDetails();
		}
		public List<StockDetails> GetStockDetailsByType(StockType stockType)
		{
			return restockRequestManager.GetStockDetailsByType(stockType);
		}
		public List<string> GetStockNamesByType(StockType stockType)
		{
			return restockRequestManager.GetStockNamesByType(stockType);
		}
		public bool AddNewStock(string stockName, StockType stockType, int quantity)
		{
			return restockRequestManager.AddNewStock(stockName, stockType, quantity);
		}
	}
}
