using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItbLearn.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItbLearn.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeCardsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(TimeCard timeCard)
        {
            return Ok("Hello");
        }
     
       
    }
}
