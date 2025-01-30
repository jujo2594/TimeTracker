using TimeTracker.Core.DTO.TimeEntry;
using TimeTracker.Core.Entities;

namespace TimeTracker.API.Services
{
    public interface ITimeEntryService
    {
        List<TimeEntryResponse> GetAllTimeEntries();
        List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest timeEntry);

        List<TimeEntryResponse>? UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntryUpdate);
    }
}
