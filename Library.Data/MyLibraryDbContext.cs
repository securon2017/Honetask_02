using Library.Core.Models;
using Library.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class MyLibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public MyLibraryDbContext(DbContextOptions<MyLibraryDbContext> options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookCongiguration());
            builder.ApplyConfiguration(new RatingConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
        }
    }
}
