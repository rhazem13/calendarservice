using calendarservice.Models;
using calendarservice.Services.CalendarEntryService;
using Microsoft.AspNetCore.Mvc;

namespace calendarservice.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class CalendarEntryController : ControllerBase
    {
        private readonly ICalendarEntryService _calendarEntryService;

        public CalendarEntryController(ICalendarEntryService calendarEntryService)
        {
            this._calendarEntryService = calendarEntryService;
        }

        [HttpGet]
        public IActionResult GetCalendarEntries()
        {
            IList<CalendarEntry> result = _calendarEntryService.GetCalendarEntries();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateCalendarEntry(CalendarEntry entry)
        {
            IList<CalendarEntry> calendarEntries = _calendarEntryService.CreateCalendarEntry(entry);
            return Ok(calendarEntries);
        }

        [HttpPut]
        public IActionResult UpdateCalendarEntry(CalendarEntry entry)
        {
            IList<CalendarEntry> calendarEntries = _calendarEntryService.UpdateCalendarEntry(entry);
            return Ok(calendarEntries);
        }

        [HttpGet("{id}")]
        public IActionResult GetCalendarEntry(int id)
        {
            return Ok(_calendarEntryService.GetCalendarEntry(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCalendarEntry(int id)
        {
            return Ok(_calendarEntryService.DeleteCalendarEntry(id));
        }
    }
}
