using EventDataCrud.Bunnies.Abstract;
using EventDataCrud.Bunnies.Concrete;
using EventDataCrud.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDataCrud.API.Controllers
{
    // http://localhost:51223/api/eventdatacrud
    [Route("api/[controller]")]
    [ApiController]
    public class EventDataCrudController : ControllerBase
    {
        private IEventDataCrudService _eventService;

        public EventDataCrudController(IEventDataCrudService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public List<EventData> Get()
        {
            return _eventService.GetAllEvents();
        }

        [HttpGet("{id}")]
        public EventData Get(int id)
        {
            return _eventService.GetEventById(id);
        }

        [HttpPost]
        public EventData Post([FromBody] EventData eventData)
        {
            return _eventService.CreateEvent(eventData);
        }

        [HttpPut]
        public EventData Put([FromBody] EventData eventData)
        {
            return _eventService.UpdataEvent(eventData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _eventService.DeleteEvent(id);
        }
    }
}
