using TimeTracker.Core.DTO.TimeEntry;
using TimeTracker.Core.Entities;

namespace TimeTracker.API.Services
{
    public interface ITimeEntryService
    {
        List<TimeEntryResponse> GetAllTimeEntries();
        List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest timeEntry);
    }
}
