using Library.Core.Models;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        private readonly MyLibraryDbContext _context;
        public ReviewRepository(MyLibraryDbContext context) : base(context)
        {
            _context = context;
        }

        public void RateBookAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
