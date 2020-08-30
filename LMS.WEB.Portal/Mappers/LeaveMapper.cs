using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Mappers
{
    public class LeaveMapper : ILeaveMapper
    {
        private readonly IMapper _mapper;
        public LeaveMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public LeaveModel LeaveModel { get; set; }
        public tbl_Leaves Leaves { get; set; }
        public LeaveModel GetLeaveModelFromLeavesOB(tbl_Leaves LeavesOB)
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<tbl_Leaves, LeaveModel>();
            });
            IMapper mapper = configuration.CreateMapper();
            LeaveModel = mapper.Map<tbl_Leaves, LeaveModel>(LeavesOB);
            return LeaveModel;
        }

        public tbl_Leaves GetLeavsOBFromLeaveModel(LeaveModel leaveModel)
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<LeaveModel, tbl_Leaves>();
            });
            IMapper mapper = configuration.CreateMapper();
            Leaves = mapper.Map< LeaveModel, tbl_Leaves>(leaveModel);
            return Leaves;
        }

        public IEnumerable<LeaveModel> GetListofLMFromLeavesOB(IEnumerable<tbl_Leaves> leavesOB)
        {
            IEnumerable<LeaveModel> LeaveModelList = null;
            var configuration = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tbl_Leaves, LeaveModel>();
            });
            IMapper mapper = configuration.CreateMapper();
            LeaveModelList = mapper.Map<IEnumerable<tbl_Leaves>, IEnumerable<LeaveModel>>(leavesOB);
            return LeaveModelList;
        }
    }
}
