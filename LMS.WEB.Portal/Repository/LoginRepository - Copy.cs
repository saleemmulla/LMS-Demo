using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.Models;

namespace LMS.WEB.Portal.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DataBaseContext _dbContext;
        public LoginRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public LoginViewModel GetLoggedInUser(string UserName, string Password)
        {
            LoginViewModel loginView = null;
            try
            {
                loginView = _dbContext.tbl_Users.Where(u => u.UserName.Equals(UserName) && u.Password.Equals(Password)).FirstOrDefault();
                return loginView;
            }
            catch
            {
                return null;
            }
        }
    }
}
