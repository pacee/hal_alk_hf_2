using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hal_alk_hf_2
{
    class Logger
    {
        private Logger()
        {

        }

        public static string fileName { get; set; }
        public static char separator = ';';

        public static void log(int succes, string userName)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(succes.ToString()+separator+userName+separator+DateTime.Now.ToString());
            writer.Close();
        }

    }
}
