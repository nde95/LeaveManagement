﻿using AutoMapper;
using EmployeeLeave.Web.Contracts;
using EmployeeLeave.Web.Data;
using EmployeeLeave.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace EmployeeLeave.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<Employee> userManager) : base(context)
        {
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);
        }
    }
}
