using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hal_alk_hf_2
{
    class Validator
    {
        public static string path;
        private UserListCreator creator;
        private List<User> users;

        public Validator()
        {
            this.creator = new UserListCreator();
            this.users = creator.createList(path);
        }

        internal bool validateUser(User user){
            try{
                foreach (var item in users){
                    if(user.userName.Equals(item.userName)){
                        if (user.password.Equals(item.password)){
                            return true;
                        }
                    }       
                }
                return false;
            }catch(Exception){
                return false;
                throw;
            }
        }
    }
}
