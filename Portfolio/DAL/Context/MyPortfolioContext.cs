using Microsoft.EntityFrameworkCore;
using MyPortfolio1.DAL.Entities;

namespace MyPortfolio1.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)   //override yapıp on yazdıktantan sonra tab tab//
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MH4E4IE\\SQLEXPRESS;initial Catalog=PortfolioDB; integrated Security=True; TrustServerCertificate=true;"); //sondaki kod yazısını ekledim ve sertifika hatası almadım.
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
