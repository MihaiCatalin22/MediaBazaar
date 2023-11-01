using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL
    {
        protected const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi464839_mediabazar; User Id = dbi464839_mediabazar; Password = 1234; TrustServerCertificate=true;";

        protected BaseDAL()
        {

        }
    }
}
