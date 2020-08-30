using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Mappers
{
    public class EmployeeDetailsMapper : IEmployeeDetailsMapper
    {
        private readonly IMapper _mapper;
        public EmployeeDetailsMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Userdetails Userdetails { get; set; }
        public tbl_EmpDetails EmpDetailsOB { get; set; }
        public tbl_EmpDetails Gettbl_EmpDetailsOBFromUserDetails(Userdetails Userdetails)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.AllowNullDestinationValues = true;
                cfg.CreateMap<Userdetails, tbl_EmpDetails>();
            });
            IMapper mapper = config.CreateMapper();
            var source = new tbl_EmpDetails();
            EmpDetailsOB = mapper.Map<Userdetails, tbl_EmpDetails>(Userdetails);
            return EmpDetailsOB;
        }
        public Userdetails GetUserDetilsFromTbl_EmpDetailsOB(tbl_EmpDetails EmpDetailsOB)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.AllowNullDestinationValues = true;
                cfg.CreateMap<tbl_EmpDetails, Userdetails>();
            });
            IMapper mapper = config.CreateMapper();
            Userdetails = mapper.Map<tbl_EmpDetails, Userdetails>(EmpDetailsOB);
            Userdetails.DepartmentName = EmpDetailsOB.Department.departmentName;
            return Userdetails;
        }
    }
}
