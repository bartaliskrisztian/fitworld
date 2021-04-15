using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<ClientMembership> ClientMemberships { get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}
