using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hal_alk_hf_2
{
    class User
    {
        public string userName { get; private set; }
        public string password { get; private set; }

        public User(string UserName, string Password)
        {
            this.userName = UserName;
            this.password = Password;
        }
    }
}
