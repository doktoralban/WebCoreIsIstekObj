using WebCoreIsIstek.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebCoreIsIstek.Infrastructure.Data
{
    public class WebCoreIsIstekContext : DbContext
    {
        public WebCoreIsIstekContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Product>(ConfigureProduct);
           
        }

        private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
               .ForSqlServerUseSequenceHiLo("WebCoreIsIstek_type_hilo")
               .IsRequired();

            builder.Property(cb => cb.ProductName)
                .IsRequired()
                .HasMaxLength(100);
        }

      


    }
}
