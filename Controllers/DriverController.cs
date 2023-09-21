using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XP.Formula1.Models;
using XP.Formula1.Models.Enums;


namespace XP.Formula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {

        private static List<Driver> drivers= new List<Driver>
        {
            new Driver
            {
                Name = "Lewis Hamilton",
                Team = "Mercedes",
                Wins = 103,
                Nationality = Nationality.GBR,
                Points = 180
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetAllDrivers()
        {
            return Ok(drivers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDriverById(Guid id)
        {
            return Ok(drivers.Find(x => x.Id.Equals(id)));
        }

        [HttpPost]
        public async Task<IActionResult> PostDriver(Driver body)
        {
            drivers.Add(body);
            return Ok(drivers);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriver(Guid id, Driver body)
        {
            var driver = drivers.Find(x => x.Id.Equals(id));

            if(driver == null) 
                return NotFound("Driver not found");

            driver = body;

            return Ok(driver);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriver(string id)
        {
            var driver = drivers.Find(x => x.Id.Equals(id));

            if (driver == null)
                return NotFound("Driver not found");

            return Ok(driver);               
            
        }

    }
}
