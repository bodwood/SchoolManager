using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagerProject.Models;

namespace SchoolManagerProject.Data
{
    public class AppDbContext : DbContext
    {
        //Constructor: connects to the database
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        //Configure the relationships between the tables.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite key for Actor_Movie.
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorId, am.MovieId });

            //One movie can have many actors.
            modelBuilder
                .Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.MovieId);

            //One actor can have many movies.
            modelBuilder
                .Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.ActorId);

            //Makes sure default behavior is applied, along with any custom configurations.
            base.OnModelCreating(modelBuilder);
        }

        //Create the tables in the database.
        //Allows me to access and interact with the tables in the database.
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
