using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using TimeTracker.Core.Entities;

namespace TimeTracker.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<TimeEntry> TimeEntries { get; set; }
    }
}
