using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XP.Formula1.Models;
using XP.Formula1.Models.Enums;
using XP.Formula1.Services.DriverService;

namespace XP.Formula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    { 
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService) 
        {
            _driverService= driverService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Driver>>> GetAllDrivers()
        {
            return _driverService.GetAllDrivers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetDriverById(Guid id)
        {
            var result = _driverService.GetDriverById(id);
            
            if(result == null)
                return NotFound("Driver not found");
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Driver>>> PostDriver(Driver body)
        {
            return Ok(_driverService.PostDriver(body));
        }

        [HttpPut]
        public async Task<ActionResult<Driver>> PutDriver( Driver body)
        {
            var result = _driverService.PutDriver(body);
            if (result == null)
                return NotFound("Driver not found");

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Driver>>> DeleteDriver(Guid id)
        {
            var result = _driverService.DeleteDriver(id); 

            if (result == null)
                return NotFound("Driver not found");

            return Ok(result);               
            
        }

    }
}
