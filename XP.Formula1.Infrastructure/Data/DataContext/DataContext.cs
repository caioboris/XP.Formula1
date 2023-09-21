using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XP.Formula1.Domain.Models;

namespace XP.Formula1.Infrastructure.Data.DataContext
{
    public class DataContext: DbContext
    {
        private static string ConnectionString = "User Id=rm552496;Password=240103;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST =oracle.fiap.com.br)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORCL)))";
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(ConnectionString, b => b.MigrationsAssembly("XP.Formula1.API"));
        }

        public DbSet<Driver> Driver { get; set; }
    }
}
