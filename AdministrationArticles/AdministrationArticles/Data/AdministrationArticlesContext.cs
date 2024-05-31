using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdministrationArticles.Models;

namespace AdministrationArticles.Data
{
    public class AdministrationArticlesContext : DbContext
    {
        public AdministrationArticlesContext (DbContextOptions<AdministrationArticlesContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

  

    }
}
