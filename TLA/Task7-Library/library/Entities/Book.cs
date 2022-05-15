using System;

namespace Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public String PublisherName { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime WrittenDate { get; set; }
        public Author Author { get; set; }

        public void Update(Book book)
        {
            this.Name = book.Name ?? this.Name;
            this.PageCount = book.PageCount == 0 ? this.PageCount : book.PageCount;
         // TODO: add fields   
        }

        public override String ToString()
        {
            return Id + " " + Name + " " + PageCount;
        }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   Id == book.Id &&
                   Name == book.Name &&
                   PageCount == book.PageCount &&
                   PublisherName == book.PublisherName &&
                   PublishDate == book.PublishDate &&
                   WrittenDate == book.WrittenDate &&
                   EqualityComparer<Author>.Default.Equals(Author, book.Author);
        }
    }
}
