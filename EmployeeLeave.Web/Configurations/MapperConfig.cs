using AutoMapper;
using EmployeeLeave.Web.Data;
using EmployeeLeave.Web.Models;

namespace EmployeeLeave.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
        }
    }
}
