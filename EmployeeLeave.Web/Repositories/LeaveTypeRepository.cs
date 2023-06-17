using EmployeeLeave.Web.Contracts;
using EmployeeLeave.Web.Data;

namespace EmployeeLeave.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
