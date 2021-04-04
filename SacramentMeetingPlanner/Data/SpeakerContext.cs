using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public class SpeakerContext : DbContext
    {
        public SpeakerContext (DbContextOptions<SpeakerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlanner.Models.Speaker> Speaker { get; set; }
    }
}
