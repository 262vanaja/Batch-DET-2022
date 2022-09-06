using Batch_DET_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch_DET_2022.Data
{
    public class BookContext : DbContext
    {
        public BookContext()
        {

        }
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)

        {
            
    }
          //public virtual DbSet<Book> Books { get; set; }
          public DbSet<Customer> Customers { get; set; }

          public DbSet<Order> Orders { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=BG4WS1532\\SQLEXPRESS;Database=Training;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Property configuration
            //fluent API
            //modelBuilder.Entity<Book>()
            //       .Property(b => b.price)

            //       .IsRequired()//[Required]
            //       .HasColumnName("BKprice")//[column ("bkprice)]
            //       .HasDefaultValue(200);

        }

             
    }


}    
            
    



