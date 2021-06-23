using EnventDataCrud.DataAccess.Abstract;
using EnventDataCrud.DataAccess.Concrete;
using EventDataCrud.Bunnies.Abstract;
using EventDataCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventDataCrud.Bunnies.Concrete
{
    public class EventDataCrudManager : IEventDataCrudService
    {
        private IEventDataCrudRepository _eventRepository;

        public EventDataCrudManager(IEventDataCrudRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public EventData CreateEvent(EventData eventData)
        {
            return _eventRepository.CreateEvent(eventData);
        }

        public void DeleteEvent(int id)
        {
            _eventRepository.DeleteEvent(id);
        }

        public List<EventData> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public EventData GetEventById(int id)
        {
            // iş kuralları
            if (id > 0)
            {
                return _eventRepository.GetEventById(id);
            }

            throw new Exception("id 0'dan küçük olamaz.");
        }

        public EventData UpdataEvent(EventData eventData)
        {
            return _eventRepository.UpdataEvent(eventData);
        }
    }
}
