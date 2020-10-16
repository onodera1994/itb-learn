using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItbLearn.WebApi.Models
{
    public class TimeCardsDbContext : DbContext
    {
        public TimeCardsDbContext(DbContextOptions<TimeCardsDbContext> options) : base(options) { }
        public DbSet<TimeCardEntity> TimeCards { get; set; }

    }
}
