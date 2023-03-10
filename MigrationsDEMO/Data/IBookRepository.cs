using MigrationsDEMO.Model;
using System.Collections.Generic;

namespace MigrationsDEMO.Data;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    void AddBook(string book);
}
