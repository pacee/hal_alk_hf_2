using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hal_alk_hf_2
{
    public class CSVReader : IReader{    
        public string readAll(string path){
            try{  
                string content = System.IO.File.ReadAllText(path);
                return content;
            }catch (Exception){
                throw;
            }
        }
        
    }
}
