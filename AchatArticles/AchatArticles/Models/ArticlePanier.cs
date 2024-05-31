namespace AchatArticles.Models
{
    public class ArticlePanier
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public Panier Panier { get; set; }

    }
}
