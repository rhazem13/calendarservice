using calendarservice.Models;
using Microsoft.EntityFrameworkCore;

namespace calendarservice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<CalendarEntry> CalendarEntries { get; set; }
    }
}
