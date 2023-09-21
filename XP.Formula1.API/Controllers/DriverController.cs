using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XP.Formula1.Domain.Interfaces.Services;
using XP.Formula1.Domain.Models;
using XP.Formula1.Infrastructure.Data.DataContext;

namespace XP.Formula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    { 
        private readonly IDriverRepository _driverRepository;

        public DriverController(IDriverRepository driverRepository ) 
        {
            _driverRepository = driverRepository ;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDrivers()
        {
            return Ok(await _driverRepository.GetAllDrivers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetDriverById(Guid id)
        {
            var result = await _driverRepository.GetDriverById(id);
            
            if(result == null)
                return NotFound("Driver not found");
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostDriver(Driver body)
        {
            return Ok(await _driverRepository.PostDriver(body));
        }

        [HttpPut]
        public async Task<ActionResult<Driver>> PutDriver( Driver body)
        {
            var result = await _driverRepository.PutDriver(body);
            if (result == null)
                return NotFound("Driver not found");

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Driver>>> DeleteDriver(Guid id)
        {
            var result = await _driverRepository.DeleteDriver(id); 

            if (result == null)
                return NotFound("Driver not found");

            return Ok(result);               
            
        }

    }
}
