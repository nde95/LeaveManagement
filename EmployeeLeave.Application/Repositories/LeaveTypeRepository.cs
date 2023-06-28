using EmployeeLeave.Application.Contracts;
using EmployeeLeave.Data;

namespace EmployeeLeave.Application.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
