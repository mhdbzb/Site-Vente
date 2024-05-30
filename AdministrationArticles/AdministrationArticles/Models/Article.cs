using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdministrationArticles.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix { get; set; }
        [Display(Name = "Quantité disponible")]
        public int QuantiteDispo {  get; set; }
    }
}
