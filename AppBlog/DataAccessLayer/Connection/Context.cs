using System.Configuration;
using Datam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Connection
{
    public class Context : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL(@"server=localhost;port=3306;database=CoreBlogDb;user=root;password=1905;");
            optionsBuilder.UseSqlServer("server=DESKTOP-0STP5KA;database=StajDatabase;integrated security=true;");






        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           




            modelBuilder.Entity<Mesaj>()
                .HasOne(x => x.AliciWriter)
                .WithMany(z => z.AldigiMesajs)
                .HasForeignKey(y => y.AliciId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mesaj>()
               .HasOne(x => x.GondWriter)
               .WithMany(z => z.GondMesajs)
               .HasForeignKey(y => y.GondericiID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Comment>()
                .HasOne(x => x.Writer)
                .WithMany(y => y.Comments)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Followers>()                                            //  1.
        .HasKey(k => new { k.Writerid, k.FollowerId });

            modelBuilder.Entity<Followers>()                                            //  3.
                 .HasOne(u => u.Follower)
                 .WithMany(u => u.Following)
                 .HasForeignKey(u => u.FollowerId)
                 .OnDelete(DeleteBehavior.ClientSetNull);


            modelBuilder.Entity<Followers>()                                            //  2.
                .HasOne(u => u.Writerim)
                .WithMany(u => u.Follower)
                .HasForeignKey(u => u.Writerid)
                .OnDelete(DeleteBehavior.ClientSetNull);


            //modelBuilder.Entity<WriterLikes>()
            //    .HasIndex(i => new { i.WriterID, i.BlogID })
                
            //    .IsUnique();

            

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SlideBar> SlideBars { get; set; }
       // public DbSet<WriterLikes> WriterLikes { get; set; }

    }
}
