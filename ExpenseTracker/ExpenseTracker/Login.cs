using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    class Login
    {
        string username;
        string password;

        // Constructor
        public Login(string _username, string _password)
        {
            username = _username;
            password = _password;
        }

        public void msg()
        {
            MessageBox.Show(username);
        }
    }
}
