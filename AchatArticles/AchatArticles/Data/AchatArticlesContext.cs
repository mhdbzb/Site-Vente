using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AchatArticles.Models;
using Microsoft.Extensions.Hosting;

namespace AchatArticles.Data
{
    public class AchatArticlesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ArticlesDB;Integrated Security=True;Encrypt=False";
            options.UseSqlServer(connectionString);
        }

        public AchatArticlesContext (DbContextOptions<AchatArticlesContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Panier> Paniers { get; set; }

       //public DbSet<ArticlePanier> ArticlesPaniers { get; set; }
        public DbSet<Historique> Historiques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Panier>()
                .HasMany(e => e.Articles)
                .WithMany(e => e.Paniers);
        }
    }
}
