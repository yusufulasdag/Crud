using EventDataCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnventDataCrud.DataAccess.Abstract
{
    public interface IEventDataCrudRepository
    {
        List<EventData> GetAllEvents();

        EventData GetEventById(int id);

        EventData CreateEvent(EventData eventData);

        EventData UpdataEvent(EventData eventData);

        void DeleteEvent(int id);
    }
}
