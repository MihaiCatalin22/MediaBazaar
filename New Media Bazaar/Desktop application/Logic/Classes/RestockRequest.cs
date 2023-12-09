﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
	public class RestockRequest
	{
		public int Id { get; set; }
		public string StockName { get; set; }
		public StockType StockType { get; set; }
		public int Quantity { get; set; }
		public DateTime RequestDate { get; set; }
	}
}