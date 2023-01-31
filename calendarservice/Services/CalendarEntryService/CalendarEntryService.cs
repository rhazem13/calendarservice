using calendarservice.Models;

namespace calendarservice.Services.CalendarEntryService
{
    public class CalendarEntryService : ICalendarEntryService
    {
        private IList<CalendarEntry> entries=new List<CalendarEntry>();

        public IList<CalendarEntry> CreateCalendarEntry(CalendarEntry entry)
        {
            entries.Add(entry);
            return entries;
        }

        public IList<CalendarEntry> GetCalendarEntries()
        {
            CalendarEntry newEntry = new CalendarEntry();
            newEntry.Date= DateTime.Now;
            newEntry.Title = "My new project";

            entries.Add(newEntry);
            return entries;
        }
    }
}
