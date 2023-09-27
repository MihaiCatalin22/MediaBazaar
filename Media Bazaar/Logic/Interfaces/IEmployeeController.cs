using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IEmployeeController
    {
        private const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234;";

        public bool Create(Employee employee);
        public bool Update(Employee employee);
        public bool Delete(Employee employee);
        public Employee[] GetAll();
        public Employee GetById(int id);
        public Employee[] GetAvailableEmployees(DateTime date, int shiftType);
    }
}
