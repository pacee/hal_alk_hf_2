using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hal_alk_hf_2
{
    class UserInfo
    {
        public readonly static MessageBoxButtons okButton = MessageBoxButtons.OK;
        public readonly static MessageBoxIcon errorIcon = MessageBoxIcon.Error;

        public static void errorMessage(string content)
        {
            MessageBox.Show(content, "Error", okButton, errorIcon);
        }

        private UserInfo() { }
    }
}
