using Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IShiftController
    {
        private const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234;";

        public bool Create(Shift shift);
        public bool Update(Shift shift);
        public bool Delete(Shift shift);
        public Shift[] GetAll();
        public Shift[] GetAllAssigned(Employee employee);
        public Shift[] GetAllByDate(DateTime date);
        public Shift GetById(int id);
        public Shift[] GetFutureShiftsByEmp(Employee employee);

    }
}
