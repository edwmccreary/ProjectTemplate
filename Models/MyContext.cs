using Microsoft.EntityFrameworkCore;
namespace ProjectTemplate.Models
{ 
    public class MyContext : DbContext
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        //Add your tables below:
        public DbSet<User> Users { get; set; }
    }
}