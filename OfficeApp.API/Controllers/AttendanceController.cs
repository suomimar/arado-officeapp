﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OfficeApp.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfficeApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("ApiAllowedOrigins")]
    public class AttendanceController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Attendance> Get()
        {
            return new List<Attendance>() {
                new Attendance()
            {
                EmployeeName="Markus",
                Note="Arriving at 9"
            } };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
