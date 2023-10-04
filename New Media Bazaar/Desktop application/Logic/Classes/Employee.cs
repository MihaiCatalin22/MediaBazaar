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
        public string ProfilePicture { get; private set; }
        public Department Department { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string username, string password, Department department)
        {
            Id = id;
            Username = username;
            Password = password;
            Department = department;
        }

        public Employee(string username, string password, Department department, string name, string email, string phone, decimal salary, int shifts)
        {
            Username = username;
            Password = password;
            Department = department;
            Name = name;
            Email = email;
            Phone = phone;
            Salary = salary;
            HireDate = DateTime.Now;
            Shifts = shifts;
        }

        public Employee(int id, string username, string password, Department department, string name, string email, string phone, decimal salary, DateTime hireDate, int shifts)
        {
            Id = id;
            Username = username;
            Password = password;
            Department = department;
            Name = name;
            Email = email;
            Phone = phone;
            Salary = salary;
            HireDate = hireDate;
            Shifts = shifts;
        }

        public Employee(int id, string username, string password, Department department, string? v1, string? v2, string? v3, decimal v4, DateTime dateTime, string? v5, int v6) : this(id, username, password, department)
        {
        }

        public void ChangeDetails(string name, string username, string phone, decimal salary)
        {
            Name = name;
            Username = username;
            Phone = phone;
            Salary = salary;
        }

        public override string ToString()
        {
            if (Email != string.Empty)
                return $"{Id}: {Name} ({Username}) - {Email}";
            return $"{Id}: {Name} ({Username})";
        }
    }
}
