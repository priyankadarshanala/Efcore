using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomainn;

//using (PubContext context = new PubContext())
//{

//    context.Database.EnsureCreated();
//}

//GetAuthors();
//AddAuthor();
//GetAuthors();

//AddAuthorWithBook();
//GetAuthorsWithBooks();

//void AddAuthorWithBook()
//{
//    var author = new Author { FirstName = "Pinky", LastName = "Darshanala" };
//    author.Books.Add(new Book
//    {
//        Title = "Programming Entity Framework",
//        PublishDate = new DateTime(2009, 1, 1)
//    });
//    author.Books.Add(new Book
//    {
//        Title = "Programming Entity Framework 2nd Ed",
//        PublishDate = new DateTime(2010, 8, 1)
//    });
//    using var context = new PubContext();
//    context.Authors.Add(author);
//    context.SaveChanges();
//}
//void GetAuthorsWithBooks()
//{
//    using var context = new PubContext();
//    var authors = context.Authors.Include(a => a.Books).ToList();
//    foreach (var author in authors)
//    {
//        Console.WriteLine(author.FirstName + " " + author.LastName);
//        foreach (var book in author.Books)
//        {
//            Console.WriteLine("*" + book.Title);
//        }
//    }
//}

//QueryFilters();
//void QueryFilters()
//{
//    var filter = "%P";
//    var authors = context.Authors
//               .Where(a => EF.Functions.Like(a.LastName, "P%")).ToList();
//}

PubContext context = new PubContext();
InsertAuthor();
void InsertAuthor()
{
    var author = new Author { FirstName = "Pinkypinky", LastName = "Darshanala" };
    context.Authors.Add(author);
    context.SaveChanges();
}
RetrieveAndUpdateAuthor();

void RetrieveAndUpdateAuthor()
{
    var author = context.Authors.FirstOrDefault(a => a.FirstName == "Pinkypinky" && a.LastName == "Darshanala");
    if (author != null)
    {
        author.FirstName = "Pinkypinky";
        context.SaveChanges();
    }
}

