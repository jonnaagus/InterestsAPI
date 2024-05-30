using InterestsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InterestsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<InterestParticipation> InterestParticipations { get; set; }
    }
}
