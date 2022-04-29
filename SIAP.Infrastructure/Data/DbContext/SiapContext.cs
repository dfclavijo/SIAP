using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SIAP.Domain.Entities;

namespace SIAP.Infrastructure.Data.DbContext
{
    public class SiapContext : IdentityDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Internship>Internships { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Fee> Fees { get; set; }
        
        
        public SiapContext(DbContextOptions<SiapContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Database schema
            builder.HasDefaultSchema("dbo");

            base.OnModelCreating(builder);

            //Model Contraints
            ModelConfig(builder);
            builder.HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
        private void ModelConfig(ModelBuilder modelBuilder)
        {
         
            //new MediaContentConfiguration(modelBuilder.Entity<MediaContent>()); 
            //new RoomTypeConfiguration (modelBuilder.Entity<RoomType>());
            //new RoomTypeBasePriceConfiguration (modelBuilder.Entity<RoomTypeBasePrice>());
            //new RoomTypePriceAddonConfiguration (modelBuilder.Entity<RoomTypePriceAddon>());
            //new TextContentConfiguration(modelBuilder.Entity<TextContent>()); 
          

        }
    }

    
}
