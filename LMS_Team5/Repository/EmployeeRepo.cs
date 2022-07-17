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
    }
}
