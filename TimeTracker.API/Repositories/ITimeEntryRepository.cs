﻿using TimeTracker.Core.Entities;

namespace TimeTracker.API.Repositories
{
    public interface ITimeEntryRepository
    {
        List<TimeEntry> GetAllTimeEntries();
        List<TimeEntry> CreateTimeEntry(TimeEntry timeEntry);

    }
}
