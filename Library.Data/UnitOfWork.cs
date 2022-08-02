using Library.Core;
using Library.Core.Repositories;
using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyLibraryDbContext _db;
        private BookRepository _bookRepository;
        private RatingRepository _ratingRepository;
        private ReviewRepository _reviewRepository;

        public UnitOfWork(MyLibraryDbContext db)
        {
            _db = db;
        }

        public IBookRepository Books 
            => _bookRepository = _bookRepository ?? new BookRepository(_db);

        public IReviewRepository Reviews
            => _reviewRepository = _reviewRepository ?? new ReviewRepository(_db);

        public IRatingRepository Rates 
            => _ratingRepository = _ratingRepository ?? new RatingRepository(_db);

        public async Task<int> CommitAsync()
        {
            return await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
