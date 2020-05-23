using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    public class Cw11Controller : ControllerBase
    {
        private readonly HospitalDbContext _context;
        
        public Cw11Controller(HospitalDbContext context)
        {
            _context = context; 
        }
        
        
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors.ToList());
        }
    }
}