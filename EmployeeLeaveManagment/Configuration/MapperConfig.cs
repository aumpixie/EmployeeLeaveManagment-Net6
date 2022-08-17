using AutoMapper;
using EmployeeLeaveManagment.Data;
using EmployeeLeaveManagment.Models;

namespace EmployeeLeaveManagment.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
