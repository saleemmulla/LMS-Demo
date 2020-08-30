using System;
using System.Linq;
using LMS.WEB.Portal.DBContexts;
using LMS.WEB.Portal.Mappers;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DataBaseContext _dbContext;
        private readonly ILoginUserMapper _userMapper;

        public LoginRepository(DataBaseContext dbContext, ILoginUserMapper userMapper)
        {
            _dbContext = dbContext;
            _userMapper = userMapper;
        }
        public LoginViewModel GetLoggedInUser(string UserName, string Password)
        {
           LoginViewModel loginView = null;
            try
            {
                tbl_Users userOB = _dbContext.tbl_Users.Where(u => u.UserName.Equals(UserName) && u.Password.Equals(Password)).FirstOrDefault();
                loginView = _userMapper.GetLoginViewModelFromUserOB(userOB);
                return loginView;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
