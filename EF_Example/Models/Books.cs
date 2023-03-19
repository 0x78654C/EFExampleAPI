namespace EF_Example.Models
{
    public class Books
    {
        public long id { get; set; }
        public string? ISBN { get; set; }
        public string? Book_Name { get; set; }
        public string? Author { get; set; }
        public string?  Category { get; set; }

        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
