using EnventDataCrud.DataAccess.Abstract;
using EventDataCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnventDataCrud.DataAccess.Concrete
{
    public class EventRepository : IEventDataCrudRepository
    {
        public EventData CreateEvent(EventData eventData)
        {
            using (var eventDbContext = new EventDataDbContext())
            {
                eventDbContext.EventDatas.Add(eventData);
                eventDbContext.SaveChanges();
                return eventData;
            }
        }

        public void DeleteEvent(int id)
        {
            using (var eventDbContext = new EventDataDbContext())
            {
                var deleteEvent = GetEventById(id);
                eventDbContext.EventDatas.Remove(deleteEvent);
                eventDbContext.SaveChanges();
            }
        }

        public List<EventData> GetAllEvents()
        {
            using (var eventDbContext = new EventDataDbContext())
            {
                return eventDbContext.EventDatas.ToList();
            }
        }

        public EventData GetEventById(int id)
        {
            using (var eventDbContext = new EventDataDbContext())
            {
                return eventDbContext.EventDatas.Find(id);
            }
        }

        public EventData UpdataEvent(EventData eventData)
        {
            using (var eventDbContext = new EventDataDbContext())
            {
                eventDbContext.EventDatas.Update(eventData);
                eventDbContext.SaveChanges();
                return eventData;
            }
        }
    }
}
