using XP.Formula1.Domain.Models;

namespace XP.Formula1.Domain.Interfaces.Services
{
    public interface IDriverService
    {
        Driver GetDriverById(Guid id);
        Driver PutDriver(Driver request);
        List<Driver> DeleteDriver(Guid id);
        List<Driver> GetAllDrivers();
        List<Driver> PostDriver(Driver request);

    }
}
