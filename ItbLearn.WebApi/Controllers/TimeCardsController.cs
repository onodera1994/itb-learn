using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItbLearn.Models;
using ItbLearn.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItbLearn.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeCardsController : ControllerBase
    {
        private readonly TimeCardsDbContext timeCardsDbContext;

        public TimeCardsController(TimeCardsDbContext timeCardsDbContext)
        {
            this.timeCardsDbContext = timeCardsDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(TimeCard timeCard)
        {
            TimeCardEntity timeCardEntity = new TimeCardEntity();

            timeCardEntity.Id = $"{timeCard.Time.ToString("yyyy-MM-dd")}-{timeCard.UserName}";
            timeCardEntity.UserName = timeCard.UserName;
            timeCardEntity.ArrivedTime = timeCard.Time;

            await timeCardsDbContext.TimeCards.AddAsync(timeCardEntity);
            
            await timeCardsDbContext.SaveChangesAsync();
            return Ok("Hello");
        }
     
       
    }
}
