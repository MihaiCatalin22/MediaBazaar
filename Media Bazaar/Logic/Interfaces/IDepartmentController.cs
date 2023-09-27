using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IDepartmentController
    {
        private const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234;";
        public bool Create(Department department);
        public bool Update(Department department);
        public bool Delete(Department department);
        public Department[] GetAll();
        public Department Get(int id);
        public Department Get(string name);
    }
}
