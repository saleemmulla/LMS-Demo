using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Mappers
{
    public interface ILoginUserMapper
    {
        LoginViewModel GetLoginViewModelFromUserOB(tbl_Users userOB);
        tbl_Users GetUserOBFromLoginViewModel(LoginViewModel loginView);
    }
}
