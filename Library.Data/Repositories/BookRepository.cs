using Library.Core.Models;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly MyLibraryDbContext context;
        public BookRepository(MyLibraryDbContext context) 
            : base(context)
        {
            this.context = context;
        }
        public new async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await context.Books
                .Include(book => book.Reviews)
                .Include(book => book.Ratings)
                .ToListAsync();
        }
        
        public async Task<IEnumerable<Book>> GetAllBooksOrderByValueAsync(string value)
        {
            return await context.Books
                .Include(b=>b.Genre)
                .ToListAsync();
        }
        
        public Task<Book> GetBookWithReviewsByBookIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetTopTenBooksByRatingAsync(string genre)
        {
            return await context.Books
                .Include(b => b.Ratings)
                .Where(b => b.Genre.Contains(genre))
                .OrderBy(b => b.Ratings)
                .Take(10)
                .ToListAsync();               
        }

        public void RemoveBookByIdWithSecretKey(int id)
        {
            throw new NotImplementedException();
        }
    }
}
