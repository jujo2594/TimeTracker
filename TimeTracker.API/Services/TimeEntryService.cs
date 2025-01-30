using Mapster;
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

        public List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest request)
        {
            var newEntry = request.Adapt<TimeEntry>(); //Usando la libreria MAPSTER.
            var result = _timeEntryRepository.CreateTimeEntry(newEntry); 
            return result.Adapt<List<TimeEntryResponse>>();  //Usando la libreria MAPSTER.
        }

        public List<TimeEntryResponse> GetAllTimeEntries()
        {
            var result = _timeEntryRepository.GetAllTimeEntries();
            return result.Adapt<List<TimeEntryResponse>>(); //Usando la libreria MAPSTER.
        }

        public List<TimeEntryResponse>? UpdateTimeEntry(int id, TimeEntryUpdateRequest request)
        {
            var updatedEntry = request.Adapt<TimeEntry>();
            var result = _timeEntryRepository.UpdateTimeEntry(id, updatedEntry);
            if( result == null )
            {
                return null;
            }
            return result.Adapt<List<TimeEntryResponse>>();
        }
    }
}
