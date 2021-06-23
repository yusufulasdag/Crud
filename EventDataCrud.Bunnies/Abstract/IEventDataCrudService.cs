using EventDataCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventDataCrud.Bunnies.Abstract
{
    public interface IEventDataCrudService
    {
        List<EventData> GetAllEvents();

        EventData GetEventById(int id);

        EventData CreateEvent(EventData eventData);

        EventData UpdataEvent(EventData eventData);

        void DeleteEvent(int id);
    }
}
