using EmployeeLeave.Web.Contracts;
using EmployeeLeave.Web.Data;

namespace EmployeeLeave.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
