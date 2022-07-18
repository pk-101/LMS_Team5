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
        Task<int> InsertLeaveAsync(LeaveDetails leaveDetails);
        Task<Employee> GetEmpByIdAsync(int id);
        Task DeleteEmpAsync(int? id);
        Task UpdateEmpAsync(int? id, Employee employee);

    }
}
