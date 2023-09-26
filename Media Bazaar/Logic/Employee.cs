using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Employee
    {
        public int Id { get; private set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string? Email { get; private set; }
        public string? Phone { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime HireDate { get; private set; }
        public int Shifts { get; private set; }
    }
}
