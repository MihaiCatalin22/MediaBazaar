using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Controllers
{
    public class LoginController
    {
        private readonly ILoginConttroller _loginConttroller;
        public LoginController(ILoginConttroller _loginConttroller) 
        { 
            this._loginConttroller = _loginConttroller;
        }

        public Login CheckLogin(string username, string password)
        {
            return _loginConttroller.CheckLogin(username, password);
        }
    }
}
