using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Mappers
{
    public interface IEmployeeDetailsMapper
    {
        Userdetails GetUserDetilsFromTbl_EmpDetailsOB(tbl_EmpDetails EmpDetailsOB);
        tbl_EmpDetails Gettbl_EmpDetailsOBFromUserDetails(Userdetails Userdetails);
    }
}
