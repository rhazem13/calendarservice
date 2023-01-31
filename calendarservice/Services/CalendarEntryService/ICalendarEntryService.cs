using calendarservice.Models;

namespace calendarservice.Services.CalendarEntryService
{
    public interface ICalendarEntryService
    {
        IList<CalendarEntry> GetCalendarEntries();

        IList<CalendarEntry> CreateCalendarEntry(CalendarEntry entry);

        IList<CalendarEntry> UpdateCalendarEntry(CalendarEntry entry);

        CalendarEntry GetCalendarEntry(int id);

        IList<CalendarEntry> DeleteCalendarEntry(int id);
    }
}
