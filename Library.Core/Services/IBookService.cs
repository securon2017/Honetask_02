using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<IEnumerable<Book>> GetAllBooksOrderByValue(string value);
        Task<IEnumerable<Book>> GetTopTenBooksByRating(string genre);
        Task<Book> GetBookWithReviewsByBookId(int id);
        Task RemoveBookByIdWithSecretKey(int id);
    }
}
