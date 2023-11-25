using Logic.Classes;
using Logic.Controllers;
using Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALEmployeeController : BaseDAL, IEmployeeController
    {      
        public bool Create(Employee employee)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Employee  (Username, Password, DepartmentID, Name, Email, Phone, Shifts, Salary, HireDate, DateOfBirth, BSN) VALUES (@username, @password, @departmentID, @name, @email, @phone, @shifts, @salary, @hiredate, @dateOfBirth, @bsn)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@shifts", employee.Shifts);                     
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@dateOfBirth", employee.DateOfBirth);
                        cmd.Parameters.AddWithValue("@bsn", employee.BSN);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Employee employee)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Employee WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Employee[] GetAll()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                DepartmentController _departmentController = new DepartmentController(new DALDepartmentController());
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string sql = "SELECT * FROM Employee";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr["ID"]);
                            string username = dr["Username"].ToString();
                            string password = dr["Password"].ToString();
                            Department department = _departmentController.Get(Convert.ToInt32(dr["DepartmentID"]));

                            // Handling nullable columns with ternary operators
                            string name = dr.IsDBNull(dr.GetOrdinal("Name")) ? null : dr["Name"].ToString();
                            string email = dr.IsDBNull(dr.GetOrdinal("Email")) ? null : dr["Email"].ToString();
                            string bsn = dr.IsDBNull(dr.GetOrdinal("BSN")) ? null : dr["BSN"].ToString();
                            DateTime? dateOfBirth = dr.IsDBNull(dr.GetOrdinal("DateOfBirth")) ? (DateTime?)null : Convert.ToDateTime(dr["DateOfBirth"]);
                            string phone = dr.IsDBNull(dr.GetOrdinal("Phone")) ? null : dr["Phone"].ToString();
                            decimal? salary = dr.IsDBNull(dr.GetOrdinal("Salary")) ? (decimal?)null : Convert.ToDecimal(dr["Salary"]);
                            DateTime? hireDate = dr.IsDBNull(dr.GetOrdinal("HireDate")) ? (DateTime?)null : Convert.ToDateTime(dr["HireDate"]);
                            int? shifts = dr.IsDBNull(dr.GetOrdinal("Shifts")) ? (int?)null : Convert.ToInt32(dr["Shifts"]);

                  
                            employees.Add(new Employee(id, username, password, department, name, email, phone, salary, hireDate, shifts, dateOfBirth, bsn));
                        }
                    }
                }
                return employees.ToArray();
            }
            catch (Exception ex)
            {
              
                Console.WriteLine(ex.Message); 
                return null;
            }
        }

        public Employee GetById(int id)
        {
            try
            {
                Employee employee = null;
                DepartmentController _departmentController = new(new DALDepartmentController());

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Department department = _departmentController.Get(Convert.ToInt32(dr[3]));
                            employee = new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department, dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), Convert.ToDecimal(dr[7]), Convert.ToDateTime(dr[8]), Convert.ToInt32(dr[9]), Convert.ToDateTime(dr[10]), dr[11].ToString());
                        }
                    }

                }
                return employee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Employee employee)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Employee SET Username = @username, Password = @password, DepartmentID = @departmentID, Name = @name, Email = @email, Phone = @phone, Shifts = @shifts, Salary = @salary, HireDate = @hiredate, DateOfBirth = @dateOfBirth, BSN = @bsn WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@shifts", employee.Shifts);
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@dateOfBirth", employee.DateOfBirth);
                        cmd.Parameters.AddWithValue("@bsn", employee.BSN);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Employee[] GetAvailableEmployees(DateTime date, int shiftType)
        {
            try
            {
                List<Employee> employees = new();
                DepartmentController _departmentController = new(new DALDepartmentController());
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM EMPLOYEE WHERE Id NOT IN" +
                        "(SELECT EmployeeId FROM Shift WHERE Date = @date AND ShiftType = @shiftType " +
                        "AND IsCancelled = 1) AND DepartmentID NOT IN (1, 2);";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@shiftType", shiftType);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Department department = _departmentController.Get(Convert.ToInt32(dr[3]));
                            if (department.Id > 2)
                                employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department, dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), Convert.ToDecimal(dr[7]), Convert.ToDateTime(dr[8]), Convert.ToInt32(dr[9]), Convert.ToDateTime(dr[10]), dr[11].ToString()));
                            else
                                employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department, Convert.ToDateTime(dr[5]), dr[6].ToString()));
                        }
                    }

                }
                return employees.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
