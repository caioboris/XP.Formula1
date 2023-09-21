using XP.Formula1.Domain.Enums;
using XP.Formula1.Domain.Interfaces.Services;
using XP.Formula1.Domain.Models;


namespace XP.Formula1.Services.DriverService
{
    public class DriverService : IDriverService
    {
        private static List<Driver> drivers = new List<Driver>
        {
            new Driver
            {
                Name = "Lewis Hamilton",
                Car = "Mercedes",
                Wins = 103,
                Nationality = Nationality.GBR,
                Points = 180
            },
            new Driver
            {
                Name = "Max Verstappen",
                Car = "Red Bull Racing Honda RBPT",
                Wins = 47,
                Nationality = Nationality.NED,
                Points = 374
            }
        };

        public List<Driver> DeleteDriver(Guid id)
        {
            var driver = drivers.Find(x => x.Id.Equals(id));

            if (driver == null) return null;

            drivers.Remove(driver);
            return drivers;
        }

        public List<Driver> GetAllDrivers()
        {
            return drivers;
        }

        public Driver GetDriverById(Guid id)
        {
            var driver = drivers.Find(x => x.Id.Equals(id));

            if (driver == null) return null;    
            return driver;
        }

        public List<Driver> PostDriver(Driver request)
        {
            drivers.Add(request);
            return drivers;
        }

        public Driver PutDriver(Driver request)
        {
            var driver = drivers.Find(x => x.Id.Equals(request.Id));

            if (driver == null) return null;

            
            driver.Points = request.Points;
            driver.Name = request.Name;
            driver.Car = request.Car;
            driver.Wins = request.Wins;
            driver.Nationality = request.Nationality;

            return driver;
        }
    }
}
