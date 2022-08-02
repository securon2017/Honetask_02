using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class RatingRepository : Repository<Rating>, IRatingRepository
    {
        public RatingRepository(MyLibraryDbContext context)
            : base(context)
        { }

        //public async Task<Rating> GetRatingAsync()
        //{
        //    return await MyLibraryDbContext.
        //}

    }
}
