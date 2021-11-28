namespace Makray_Robert_Lab._8.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        public string PublisherName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
