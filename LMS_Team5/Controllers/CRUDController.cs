﻿using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        [Route("DisplayAll")]
        public async Task<IActionResult> GetEmp()
        {
            var ar = await employeeRepo.GetEmployeesAsync();
            return Ok(ar);
        }
    }
}
