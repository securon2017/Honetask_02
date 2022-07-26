using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IReviewRepository Reviews { get; }
        IRatingRepository Rates { get; }
        Task<int> CommitAsync();
    }
}
