using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RolodexApp.Models;

namespace RolodexApp.Data
{
    public class RolodexContext : DbContext
    {
        public RolodexContext (DbContextOptions<RolodexContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(
                new Person 
                {
                    PersonId = 1,
                    FirstName = "Jesse",
                    LastName = "Harlan",
                    PhoneNumber = "1234567890",
                    Email = "jesse@jesse.com"
                },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Tom",
                    LastName = "Jones",
                    PhoneNumber = "1234567891",
                    Address1 = "123 Someplace Ln",
                    City = "No Place",
                    State = "NY",
                    PostalCode = "12345"
                },
                new Person
                {
                    PersonId = 3,
                    FirstName = "Sue",
                    LastName = "Jones",
                    PhoneNumber = "1234567892",
                    Address1 = "123 Someplace Ln",
                    City = "No Place",
                    State = "NY",
                    PostalCode = "12345"
                }
            );
        }

        public DbSet<RolodexApp.Models.Person> Person { get; set; } = default!;
    }
}
