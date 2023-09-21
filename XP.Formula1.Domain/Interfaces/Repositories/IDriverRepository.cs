using XP.Formula1.Domain.Models;

namespace XP.Formula1.Domain.Interfaces.Services
{
    public interface IDriverRepository
    {
        Task<Driver> GetDriverById(Guid id);
        Task<Driver> PutDriver(Driver request);
        Task<List<Driver>> DeleteDriver(Guid id);
        Task<List<Driver>> GetAllDrivers();
        Task<List<Driver>> PostDriver(Driver request);

    }
}
