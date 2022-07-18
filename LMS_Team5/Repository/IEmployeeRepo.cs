using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_Team5.Model;

namespace LMS_Team5.Repository
{
   public interface IEmployeeRepo
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmpByIdAsync(int id);
        Task<int> InsertLeaveAsync(LeaveDetails leaveDetails);
    }
}
