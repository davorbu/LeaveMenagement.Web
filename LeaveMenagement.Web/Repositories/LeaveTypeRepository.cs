using LeaveMenagement.Web.Contracts;
using LeaveMenagement.Web.Data;

namespace LeaveMenagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
