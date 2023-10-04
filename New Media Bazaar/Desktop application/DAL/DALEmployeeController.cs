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
    public class DALEmployeeController 
    {
        //private const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234;";

        //public bool Create(Employee employee)
        //{
        //    try
        //    {
        //        using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
        //        {
        //            string sql = "INSERT INTO Employee (Username, Password, DepartmentID, Name, Email, Phone, Shifts, ProfilePicture, Salary, HireDate) VALUES (@username, @password, @departmentID, @name, @email, @phone, @shifts, @profilepicture, @salary, @hiredate)";

        //            using (SqlCommand cmd = new SqlCommand(sql, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@username", employee.Username);
        //                cmd.Parameters.AddWithValue("@password", employee.Password);
        //                cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
        //                cmd.Parameters.AddWithValue("@name", employee.Name);
        //                cmd.Parameters.AddWithValue("@email", employee.Email);
        //                cmd.Parameters.AddWithValue("@phone", employee.Phone);
        //                cmd.Parameters.AddWithValue("@shifts", employee.Shifts);
        //                cmd.Parameters.AddWithValue("@profilepicture", "https://upload.wikimedia.org/wikipedia/commons/2/2c/Default_pfp.svg");
        //                cmd.Parameters.AddWithValue("@salary", employee.Salary);
        //                cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);

        //                conn.Open();
        //                int result = cmd.ExecuteNonQuery();

        //                if (result < 0) return false;
        //            }

        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}



    }
}
