using ClassLibrary.Classes;

namespace DAL
{
    public class DALEmployeeController
    {
        private const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234;";

        public bool Create(Employee employee)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Employee (Username, Password, Email, Name, Gender, Salary, HireDate) VALUES (@username, @password, @email, @name, @gender, @salary, @hiredate";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@gender", employee.Gender);
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);

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
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING)
            }
        }
    }
}