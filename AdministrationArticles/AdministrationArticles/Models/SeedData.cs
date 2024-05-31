using AdministrationArticles.Data;
using Microsoft.EntityFrameworkCore;

namespace AdministrationArticles.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AdministrationArticlesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AdministrationArticlesContext>>()))
            {
                // Look for any Articles.
                if (context.Articles.Any())
                {
                    return;   // DB has been seeded
                }
                context.Articles.AddRange(
                    new Article
                    {
                        Nom = "Téléphone",
                        Prix = 399.99M,
                        QuantiteDispo = 4
                    },
                    new Article
                    {
                        Nom = "Ordinateur",
                        Prix = 1399.99M,
                        QuantiteDispo = 2,
                    },
                    new Article
                    {
                        Nom = "Tablette",
                        Prix = 799.99M,
                        QuantiteDispo = 34
                    },
                    new Article
                    {
                        Nom = "Casque audio",
                        Prix = 299.99M,
                        QuantiteDispo = 23
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

