using FreelancerDirectory.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FreelancerDirectory.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User 
                {
                    Id = 1, 
                    UserName = "Alice", 
                    Mail = "alice@example.com", 
                    PhoneNumber = "1234567890", 
                    Skillsets = "Web Development", 
                    Hobby = "Drawing" 
                }
            );
        }
    }
}
    


