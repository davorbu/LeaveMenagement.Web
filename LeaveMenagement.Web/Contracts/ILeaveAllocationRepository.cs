﻿using LeaveMenagement.Web.Data;
using LeaveMenagement.Web.Models;

namespace LeaveMenagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
      Task   LeaveAllocation (int leaveTypeId);

      Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);

        Task<bool> UpdateEmployeeAllocation (LeaveAllocationEditVM model);
    }
}