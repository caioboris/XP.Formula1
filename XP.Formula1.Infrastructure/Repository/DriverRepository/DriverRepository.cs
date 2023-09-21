using Microsoft.EntityFrameworkCore;
using XP.Formula1.Domain.Enums;
using XP.Formula1.Domain.Interfaces.Services;
using XP.Formula1.Domain.Models;
using XP.Formula1.Infrastructure.Data.DataContext;

namespace XP.Formula1.Services.DriverService
{
    public class DriverRepository : IDriverRepository
    {
        private readonly DataContext _context;

        public DriverRepository(DataContext context) 
        { 
            _context = context;
        }

        public async Task<List<Driver>> DeleteDriver(Guid id)
        {
            var driver = await _context.Driver.FindAsync(id);

            if (driver == null) return null;

            _context.Driver.Remove(driver);
            return await _context.Driver.ToListAsync();
        }

        public async Task<List<Driver>> GetAllDrivers()
        {
            return await _context.Driver.ToListAsync() ;
        }

        public async Task<Driver> GetDriverById(Guid id)
        {
            var driver = await _context.Driver.FindAsync(id);

            if (driver == null) return null;    
            return driver;
        }

        public async Task<List<Driver>> PostDriver(Driver request)
        {
            _context.Driver.Add(request);
            
            return await _context.Driver.ToListAsync();
        }

        public async Task<Driver> PutDriver(Driver request)
        {
            var driver = await _context.Driver.FindAsync(request.Id);

            
            if (driver == null) return null;

            driver.Points = request.Points;
            driver.Name = request.Name;
            driver.Car = request.Car;
            driver.Wins = request.Wins;
            driver.Nationality = request.Nationality;
            await _context.SaveChangesAsync();

            return driver;
        }
    }
}
