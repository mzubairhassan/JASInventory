using JASDataModel.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASDataModel
{
    public class UserFactory
    {

        UserSql userCreator;

        public UserFactory()
        {
            userCreator = new UserSql();
        }

        public bool Insert(User user)
        {
            return userCreator.Insert(user);
        }

        public string selectUser(string username, string password)
        {
            string error = "NA";
            User user = new User();
            user = userCreator.selectUser(username);
            if (user != null)
            {
                if (user.UserName == username && user.Password == password) {
                    error = "Log In SuccessFull";
                    return error;
            }
                else{
                    error = "username or password incorrect";
                    return error;
                }

            }

            return error;
        }
    }
}
