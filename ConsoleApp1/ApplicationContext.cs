using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Personal> personal { get; set; } = null!;
        public DbSet<Book> book { get; set; } = null!;
        public DbSet<Arenda> arenda { get; set; } = null!;
        public ApplicationContext()
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //   optionsBuilder.UseSqlServer(@"Server=COB-C201-4;Database=test;Trusted_Connection=True;");
             optionsBuilder.UseSqlServer(@"Persist Security Info=False;Integrated Security=true; Initial Catalog=topchik;Server=COB-C201-4");
        }
    }
}
