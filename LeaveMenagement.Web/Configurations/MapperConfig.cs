using AutoMapper;
using LeaveMenagement.Web.Data;
using LeaveMenagement.Web.Models;

namespace LeaveMenagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
