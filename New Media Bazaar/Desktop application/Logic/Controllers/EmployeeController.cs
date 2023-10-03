﻿using Logic.Classes;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Controllers
{
    public class EmployeeController
    {
        private IEmployeeController _employeeDal;
        public Employee? LoggedInEmployee { get; set; }
        public EmployeeController(IEmployeeController employeeController)
        {
            _employeeDal = employeeController;
        }
        public bool AddEmployee(Employee employee)
        {
            return _employeeDal.Create(employee);
        }
        public bool RemoveEmployee(Employee employee)
        {
            return _employeeDal.Delete(employee);
        }
        public bool UpdateEmployee(Employee employee)
        {
            return _employeeDal.Update(employee);
        }
        public Employee[] GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int id)
        {
            foreach (Employee employee in GetAll())
            {
                if (employee.Id == id) return employee;
            }
            return null;
        }
        public Employee[] GetAllByDepartment(Department department)
        {
            List<Employee> employees = new();
            foreach (Employee employee in GetAll())
            {
                if (employee.Department.Id == department.Id)
                {
                    employees.Add(employee);
                }
            }
            return employees.ToArray();
        }
        public Employee Login(string username, string password)
        {
            foreach (Employee employee in GetAll())
            {
                if (employee.Username == username && employee.Password == password)
                {
                    return employee;
                }
            }
            return null;
        }

        public bool IsAdmin(Employee employee)
        {
            if (employee.Department.Name == "Administration")
                return true;
            return false;
        }
        public bool IsManager(Employee employee)
        {
            if (employee.Department.Name == "Management")
                return true;
            return false;
        }
        public Employee[] GetAvailableEmployees(DateTime date, int shiftType)
        {
            return _employeeDal.GetAvailableEmployees(date, shiftType);
        }
    }
}
