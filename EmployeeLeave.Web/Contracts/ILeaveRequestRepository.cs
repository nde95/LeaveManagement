using EmployeeLeave.Web.Data;
using EmployeeLeave.Web.Models;

namespace EmployeeLeave.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
    }
}
