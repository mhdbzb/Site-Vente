using AchatArticles.Models;
using System.ComponentModel.DataAnnotations;

namespace AchatArticles.Models
{
    public class Historique
    {
        public int Id { get; set; }
        public decimal? MontantPanier { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateAchat { get; set; }
        public Panier? Panier { get; set; }
    }
}
