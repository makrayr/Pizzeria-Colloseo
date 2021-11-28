namespace Makray_Robert_Lab._8.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
