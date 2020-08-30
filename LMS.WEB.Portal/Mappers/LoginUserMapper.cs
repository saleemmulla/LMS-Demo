using AutoMapper;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Mappers
{
  

    public class LoginUserMapper : ILoginUserMapper
    {
        private readonly IMapper _mapper;
        public LoginUserMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        LoginViewModel LoginViewModel { get; set; }
        tbl_Users UserOB { get; set; }
        public LoginViewModel GetLoginViewModelFromUserOB(tbl_Users userOB)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<tbl_Users, LoginViewModel>();
            });
            IMapper iMapper = config.CreateMapper();
            LoginViewModel = iMapper.Map<tbl_Users, LoginViewModel>(userOB);
            return LoginViewModel;
        }
        public tbl_Users GetUserOBFromLoginViewModel(LoginViewModel  loginView)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LoginViewModel, tbl_Users>();
            });
            IMapper iMapper = config.CreateMapper();
            UserOB = iMapper.Map<LoginViewModel, tbl_Users>(loginView);
            return UserOB;
        }
    }
}
