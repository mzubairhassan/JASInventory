using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASDataModel.DataAccessLayer
{
    class UserSql
    {

        JASDataSource dbContext;

        public UserSql()
        {
            dbContext = new JASDataSource();
        }

        public bool Insert(User user)
        {
            dbContext.Users.Add(user);
            return dbContext.SaveChanges() > 0;
        }

        public User selectUser(string username)
        {
            return dbContext.Users.Where(x => x.UserName == username).FirstOrDefault();

        }


    }
}
