using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AchatArticles.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Nom { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix { get; set; }
        [Display(Name = "Quantité disponible")]
        public int QuantiteDispo {  get; set; }
        public List<Panier> Paniers { get; set; }
    }
}
