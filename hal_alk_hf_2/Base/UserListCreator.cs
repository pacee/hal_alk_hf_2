using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hal_alk_hf_2
{
    class UserListCreator
    {
        private List<User> list;
        private CSVReader reader = new CSVReader();
        

        public List<User> createList(string path)
        {
            this.list = new List<User>();

            string raw = reader.readAll(path);

            string[] lines = raw.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                string userName = values[0];
                string password = values[1];
                list.Add(new User(userName, password));
            }

            return list;
        }
    }
}
