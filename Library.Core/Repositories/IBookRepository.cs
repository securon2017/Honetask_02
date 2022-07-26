using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllBooksOrderByValueAsync(string value);
        Task<IEnumerable<Book>> GetTopTenBooksByRatingAsync(string genre);
        Task<Book> GetBookWithReviewsByBookIdAsync(int id);
        void RemoveBookByIdWithSecretKey(int id);
    }
}
