using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LMS_Team5.Model;
using LMS_Team5.Repository;

namespace LMS_Team5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;
        public CRUDController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        //This is to show all employees
        [HttpGet]
        [Route("DisplayAll")]
        public async Task<IActionResult> GetEmp()
        {
            var ar = await employeeRepo.GetEmployeesAsync();
            return Ok(ar);
        }

        //With the help to this employees acn apply leave
        [HttpPost]
        [Route("InsertLeave")]
        public async Task<IActionResult> ApplyLeave(LeaveDetails leaveDetails)
        {
            var ar = await employeeRepo.InsertLeaveAsync(leaveDetails);
            return Ok(ar);
        }


        //With this we can search any employee with his/her emp_id
        [HttpGet]
        [Route("SearchById")]
        public async Task<IActionResult> Search(int id)
        {
            var ar = await employeeRepo.GetEmpByIdAsync(id);
            return Ok(ar);

        }

        //This is used to delete record from emp table
        [HttpDelete]
        [Route("DeleteEmp")]
        public async Task<IActionResult> DeleteEmployee(int? id)
        {
            if (id != null)
            {
                await employeeRepo.DeleteEmpAsync(id);
                return Ok();
            }
            return NotFound();
        }

        //This is to update emptable
        [HttpPut]
        [Route("UpdateEmp/{id?}")]
        public async Task<IActionResult> UpdateEmployee(int? id, Employee employee)
        {
            if (id != null)
            {
                await employeeRepo.UpdateEmpAsync(id, employee);
                return Ok();
            }
            return NotFound();
        }

        //This is for signin
        [HttpGet]
        [Route("EmpLogin/{Emp_email}/{Password}")]
        public async Task<int> Emp_Login(string Emp_email, string Password)
        {
            var lg = await employeeRepo.LoginAsync(Emp_email, Password);
            if (lg == 0)
                return 0;
            else
                return 1;
        }
    }
}
