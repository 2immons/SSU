using System;

namespace Task7Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public String PublisherName { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime CreationDate { get; set; }
        public Author Author { get; set; }

        public void Update(Book book)
        {
            this.Name = book.Name ?? this.Name;
            this.PageCount = book.PageCount == 0 ? this.PageCount : book.PageCount;
        }

        public override String ToString()
        {
            return $"{Id} {Name} {PageCount}";
        }
    }
}
