using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER=DESKTOP-I6RBC1D;database=TraversalDB;integrated security=true;Trusted_Connection=True; MultipleActiveResultSets=true; Encrypt=False;");
        }

        public DbSet<About> Aboutss { get; set; } // veritabanındaki tablonun ismi
        public DbSet<About2> About2ss { get; set; }
        public DbSet<Contact> Contactss { get; set; }
        public DbSet<Destination> Destinationss { get; set; }
        public DbSet<Feature> Featuress { get; set; }
        public DbSet<Feature2> Feature2ss { get; set; }
        public DbSet<Guide> Guidess { get; set; }
        public DbSet<NewsLetter> NewsLetterss { get; set; }
        public DbSet<SubAbout> SubAboutss { get; set; }
        public DbSet<Testimonial> Testimonialss { get; set; }
        public DbSet<Comment> Commentss { get; set; }
        public DbSet<Rezervasyon> Rezervasyonss { get; set; }
    }
}
