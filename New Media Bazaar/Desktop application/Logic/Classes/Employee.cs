using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? BSN { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int Shifts { get; set; }
        public Department Department { get; set; }


        public Employee()
        {
        }

        public Employee(int id, string username, string password, Department department, DateTime? dateOfBirth, string? bsn)
        {
            Id = id;
            Username = username;
            Password = password;
            Department = department;
            DateOfBirth = dateOfBirth ?? DateTime.MinValue;
            BSN = bsn;
        }


        public Employee(int id, string username, string password, Department department, string name, string? email, string? phone, decimal? salary, DateTime? hireDate, int? shifts, DateTime? dateOfBirth, string? bsn)
        {
            Id = id;
            Username = username;
            Password = password;
            Department = department;
            Name = name;
            Email = email;
            Phone = phone;
            Salary = salary ?? 0;
            HireDate = hireDate ?? DateTime.Now;
            Shifts = shifts ?? 0;
            DateOfBirth = dateOfBirth ?? DateTime.MinValue;
            BSN = bsn;
        }

        public void ChangeDetails(string name, string username, string phone, decimal salary, DateTime dateOfBirth, string? bsn)
        {
            Name = name;
            Username = username;
            Phone = phone;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            BSN = bsn;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} ({Username}) - Email: {Email}, DOB: {DateOfBirth.ToShortDateString()}, BSN: {BSN ?? "N/A"}";
        }


    }
}
