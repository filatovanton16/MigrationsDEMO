using Microsoft.EntityFrameworkCore;
using MigrationsDEMO.Context;
using MigrationsDEMO.Data;
using MigrationsDEMO.Model;
using System.Collections.Generic;
using System.Linq;

namespace MigrationsDEMO.Repositories;

public class BookRepository : IBookRepository
{
    private readonly ApplicationContext db;

    public BookRepository()
    {
        db = new ApplicationContext();
        db.Database.Migrate();
    }

    public void AddBook(string book)
    {
        db.Books.Add(new()
        {
            Name = book,
            Author = "NotImplemented"
        });
        db.SaveChanges();
    }

    public List<Book> GetAllBooks()
    {
        return db.Books.ToList();
    }
}
