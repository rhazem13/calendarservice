using calendarservice.Data;
using calendarservice.Models;

namespace calendarservice.Services.CalendarEntryService
{
    public class CalendarEntryService : ICalendarEntryService
    {
        private readonly DataContext _context;
        private IList<CalendarEntry> entries=new List<CalendarEntry>();

        public CalendarEntryService(DataContext context)
        {
            this._context = context;
        }

        public IList<CalendarEntry> CreateCalendarEntry(CalendarEntry entry)
        {
            _context.CalendarEntries.Add(entry);
            _context.SaveChanges();
            return _context.CalendarEntries.ToList();
        }

        public IList<CalendarEntry> UpdateCalendarEntry(CalendarEntry newEntry)
        {
            CalendarEntry entry=_context.CalendarEntries.FirstOrDefault(e=>e.Id==newEntry.Id);
            entry.Title = newEntry.Title;
            entry.Date = newEntry.Date;
            _context.SaveChanges();
            return _context.CalendarEntries.ToList();
        }

        public IList<CalendarEntry> GetCalendarEntries()
        {
            IList<CalendarEntry> entries = _context.CalendarEntries.ToList();
            CalendarEntry newEntry = new CalendarEntry();
            return entries;
        }

        public CalendarEntry GetCalendarEntry(int id)
        {
            return _context.CalendarEntries.FirstOrDefault(c => c.Id == id);
        }

        public IList<CalendarEntry> DeleteCalendarEntry(int id)
        {
            CalendarEntry entry = _context.CalendarEntries.FirstOrDefault(c => c.Id == id);
            _context.CalendarEntries.Remove(entry);
            _context.SaveChanges();
            return _context.CalendarEntries.ToList();
        }
    }
}
