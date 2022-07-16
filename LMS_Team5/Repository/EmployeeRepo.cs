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
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var empDetails = await dataAccessLayerDB.employees.ToListAsync();
            var data = mapper.Map<List<Employee>>(empDetails);
            return data;
        }
    }
}
