using calendarservice.Models;

namespace calendarservice.Services.CalendarEntryService
{
    public interface ICalendarEntryService
    {
        IList<CalendarEntry> GetCalendarEntries();

        IList<CalendarEntry> CreateCalendarEntry(CalendarEntry entry);
    }
}
