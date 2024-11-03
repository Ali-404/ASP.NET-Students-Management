using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data.Models;

namespace StudentsManagement.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        

        //db sets

        public DbSet<Student> Students { get; set; }   
        public DbSet<Classe> Classes { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(c => c.StudentClasse)
                .WithMany(c => c.Students);

        
        }

    }
}
