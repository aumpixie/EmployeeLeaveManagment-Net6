using EmployeeLeaveManagment.Data;
using EmployeeLeaveManagment.Models;

namespace EmployeeLeaveManagment.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<List<LeaveRequest>> GetAllAsync(string employeeId);

        Task ChangedApprovalStatus(int leaveRequestId, bool approved);

        Task CancelRequest(int leaveRequestId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

    }
}
