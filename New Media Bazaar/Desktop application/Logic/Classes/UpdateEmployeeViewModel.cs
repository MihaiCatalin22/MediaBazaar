using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
	public class UpdateEmployeeViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Phone]
		public string Phone { get; set; }

		public string Password { get; set; }
	}
}
