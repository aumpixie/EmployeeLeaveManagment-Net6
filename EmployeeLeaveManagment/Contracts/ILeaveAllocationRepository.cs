using EmployeeLeaveManagment.Data;
using EmployeeLeaveManagment.Models;

namespace EmployeeLeaveManagment.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);

        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
    }
}
