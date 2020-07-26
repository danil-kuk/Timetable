using IzhCloud_Timetable.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzhCoil_Timetable.Models
{
    public class EFDBContext : DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options) { }

        public DbSet<Day> Entries { get; set; }
    }
}
