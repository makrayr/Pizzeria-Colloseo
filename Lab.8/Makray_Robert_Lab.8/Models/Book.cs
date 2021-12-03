using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Makray_Robert_Lab._8.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$"), ErrorMessage = "Numele autorului trebuie sa fie de forma 'Prenume Nume'", Required, StringLength(50, MinimumLength = 3)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Range(1, 300)]

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
