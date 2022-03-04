#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vaccinated_Profile.Profile;

namespace Vaccinated_Profile.Data
{
    public class Vaccinated_ProfileContext : DbContext
    {
        public Vaccinated_ProfileContext (DbContextOptions<Vaccinated_ProfileContext> options)
            : base(options)
        {
        }

        public DbSet<Vaccinated_Profile.Profile.Class> Class { get; set; }
    }
}
