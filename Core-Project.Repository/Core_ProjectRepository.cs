using System.Threading.Tasks;
using Core_Project.Domain;

namespace Core_Project.Repository
{
    public class Core_ProjectRepository : ICore_ProjectRepository
    {
        public readonly Core_ProjectContext _context;
        public Core_ProjectRepository(Core_ProjectContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Cliente[]> GetAllClientesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}