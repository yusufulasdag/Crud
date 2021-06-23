using EventDataCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnventDataCrud.DataAccess
{
    public class EventDataDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string servername = "ULAS" + @"\" + "SQLEXPRESS";
            optionsBuilder.UseSqlServer("Server="+ servername + "; Database=EventDataDb; uid=as; pwd=1234;");
        }

        public DbSet<EventData> EventDatas { get; set; }
    }
}
