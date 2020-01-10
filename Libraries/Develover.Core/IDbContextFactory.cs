using System.Data.Entity;

namespace Develover.Core
{
    public interface IDbContextFactory
    {
        DbContext GetDbContext();
    }

    public class DbContextFactory<T> : IDbContextFactory where T : DbContext, new()
    {
        private readonly DbContext _context;
        public DbContextFactory()
        {
            _context = new T();
        }
        public DbContext GetDbContext()
        {
            return _context;
        }
    }
}
