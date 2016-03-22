using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hal_alk_hf_2
{
    public class InputValidator
    {
        public static bool inputDataValidator(string userName, string password)
        {
            if (
                String.IsNullOrWhiteSpace(userName) ||
                String.IsNullOrWhiteSpace(password)
               )
            {
                return false;
            }
            return true;
        }

        private InputValidator()
        {

        }
    }
}
