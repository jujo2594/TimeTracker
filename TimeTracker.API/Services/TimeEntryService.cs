using TimeTracker.API.Repositories;
using TimeTracker.Core.DTO.TimeEntry;
using TimeTracker.Core.Entities;

namespace TimeTracker.API.Services
{
    public class TimeEntryService : ITimeEntryService
    {
        private readonly ITimeEntryRepository _timeEntryRepository;

        public TimeEntryService(ITimeEntryRepository timeEntryRepository)
        {
            _timeEntryRepository = timeEntryRepository;
        }

        public List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest timeEntry)
        {
            var newEntry = new TimeEntry
            {
                Project = timeEntry.Project,
                Start = timeEntry.Start,
                End = timeEntry.End
            };
            var result = _timeEntryRepository.CreateTimeEntry(newEntry); 
            return result.Select(t => new TimeEntryResponse 
            { 
                Id = t.Id, 
                Project = t.Project, 
                Start = t.Start, 
                End = t.End 
            }).ToList();
        }

        public List<TimeEntryResponse> GetAllTimeEntries()
        {
            var result = _timeEntryRepository.GetAllTimeEntries();
            return result.Select(t => new TimeEntryResponse
            {
                Id = t.Id,
                Project = t.Project,
                Start = t.Start,
                End = t.End
            }).ToList();
        }
    }
}
