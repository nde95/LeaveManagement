﻿using EmployeeLeave.Web.Data;
using EmployeeLeave.Web.Models;

namespace EmployeeLeave.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task<AdminViewLeaveRequestsVM> GetAdminLeaveRequestList();
    }
}
