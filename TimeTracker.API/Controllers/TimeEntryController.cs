﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.API.Repositories;
using TimeTracker.API.Services;
using TimeTracker.Core.DTO.TimeEntry;
using TimeTracker.Core.Entities;

namespace TimeTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryService _timeEntryService;

        public TimeEntryController(ITimeEntryService timeEntryService)
        {
            _timeEntryService = timeEntryService;
        }

        [HttpGet]
        public ActionResult<List<TimeEntryResponse>> GetAllTimeEntries()
        {
            return Ok(_timeEntryService.GetAllTimeEntries());
        }

        [HttpPost]
        public ActionResult<List<TimeEntryResponse>> CreateTimeEntry(TimeEntryCreateRequest timeEntry)
        {
            return Ok(_timeEntryService.CreateTimeEntry(timeEntry));
        }

        [HttpPut("{id}")]
        public ActionResult<List<TimeEntryResponse>> UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntry)
        {
            var result = _timeEntryService.UpdateTimeEntry(id, timeEntry);
            if(result == null)
            {
                return NotFound("Time Entry with the given Id was not found!");
            }
            return Ok(result);
        }

    }
}
