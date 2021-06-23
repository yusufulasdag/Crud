using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventDataCrud.Entities
{
    public class EventData
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime EventDateUtc { get; set; }
        public string EventName { get; set; }
        public string EventDetail { get; set; }
    }
}
