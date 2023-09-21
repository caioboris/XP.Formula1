using FakeItEasy;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using XP.Formula1.Controllers;
using XP.Formula1.Domain.Interfaces.Services;
using XP.Formula1.Domain.Models;

namespace XP.Formula1.Test.Controller
{
    public class DriverControllerTest
    {
        private readonly IDriverRepository _driverRepository;

        public DriverControllerTest()
        {
            _driverRepository = A.Fake<IDriverRepository>();
        }

        [Fact]
        public void DriverController_PostDriver_ReturnOK()
        {
            var driver = new Driver
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Car = "Test",
                Nationality = Domain.Enums.Nationality.USA,
                Points= 0,
                Wins = 0
            };

            var controller = new DriverController(_driverRepository);

            Assert.NotNull(controller.PostDriver(driver)); 
            
        }
    }
}
    