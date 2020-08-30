using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;

namespace LMS.WEB.Portal.Mappers
{
    public class LeaveTypeMapper : ILeaveTypeMapper
    {
        private readonly IMapper _mapper;
        public LeaveTypeMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<LeaveType> GetListofLeaveTypeFromLeaveTypeOB(IEnumerable<tbl_LeaveType> leaveTypeOB)
        {
            IEnumerable<LeaveType> LeaveTypeList = null;
            var configuration = new MapperConfiguration(cfg => {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<tbl_LeaveType, LeaveType>();
            });
            IMapper mapper = configuration.CreateMapper();
            LeaveTypeList = mapper.Map<IEnumerable<tbl_LeaveType>, IEnumerable<LeaveType>>(leaveTypeOB);
            return LeaveTypeList;
        }
    }
}
