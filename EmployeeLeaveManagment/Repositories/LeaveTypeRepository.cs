using EmployeeLeaveManagment.Contracts;
using EmployeeLeaveManagment.Data;

namespace EmployeeLeaveManagment.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
