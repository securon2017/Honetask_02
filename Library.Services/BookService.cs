using Library.Core;
using Library.Core.Models;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _unitOfWork.Books.GetAllAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksOrderByValue(string value)
        {
            return await _unitOfWork.Books.GetAllBooksOrderByValueAsync(value);
        }

        public Task<Book> GetBookWithReviewsByBookId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetTopTenBooksByRating(string genre)
        {
            throw new NotImplementedException();
        }

        public Task RemoveBookByIdWithSecretKey(int id)
        {
            throw new NotImplementedException();
        }
    }
}
