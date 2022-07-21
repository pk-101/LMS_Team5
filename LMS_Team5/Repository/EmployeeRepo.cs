using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using LMS_Team5.Model;
using LMS_Team5.DataAccessLayer;

namespace LMS_Team5.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DataAccessLayerDB dataAccessLayerDB;
        private readonly IMapper mapper;

        public EmployeeRepo(DataAccessLayerDB dataAccessLayerDB, IMapper mapper)
        {
            this.dataAccessLayerDB = dataAccessLayerDB;
            this.mapper = mapper;
        }
        //This method is used to fetch all the employees and return in a list
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var empDetails = await dataAccessLayerDB.employees.ToListAsync();
            var data = mapper.Map<List<Employee>>(empDetails);
            return data;
        }

        //This method is used to apply leave , and insert it into leavedetails table
        public async Task<int> InsertLeaveAsync(LeaveDetails leaveDetails)
        {
            var ar = mapper.Map<LeaveDetailsDB>(leaveDetails);
            dataAccessLayerDB.leaveDetails.Add(ar);
            await dataAccessLayerDB.SaveChangesAsync();
            return 1;

        }

        //This method is used to search any employee with his/her emp_id from employee table
        public async Task<Employee> GetEmpByIdAsync(int id)
        {
            var ar = await dataAccessLayerDB.employees.Where(x => x.Emp_Id == id).FirstOrDefaultAsync();
            var w = mapper.Map<Employee>(ar);
            return w;

        }

        public async Task DeleteEmpAsync(int? id)
        {
            var ar =  dataAccessLayerDB.employees.FirstOrDefault(x => x.Emp_Id == id);
            if (ar != null)
            {
                dataAccessLayerDB.employees.Remove(ar);
            }
            await dataAccessLayerDB.SaveChangesAsync();
        }

        public async Task UpdateEmpAsync(int? id, Employee employee)
        {

            var ar = dataAccessLayerDB.employees.FirstOrDefault(x => x.Emp_Id == id);
            if (ar != null)
            {
                ar.Emp_Name = employee.Emp_Name;
                ar.Emp_Email = employee.Emp_Email;
                ar.Emp_Dept = employee.Emp_Dept;
                ar.Emp_Doj = employee.Emp_Doj;
                ar.Emp_Phone = employee.Emp_Phone;
                ar.Emp_LeaveBal = employee.Emp_LeaveBal;
                await dataAccessLayerDB.SaveChangesAsync();
            }
           
        }

        public async Task<int> LoginAsync(string Emp_email, string Password)
        {
            var data = await dataAccessLayerDB.employees.FirstOrDefaultAsync(x => x.Emp_Email == Emp_email & x.Password == Password);
            if (data != null)
            {
                var ar = mapper.Map<Employee>(data);
                return 1;
            }
            return 0;
        }
    }
}
