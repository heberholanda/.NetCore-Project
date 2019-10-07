using System.Linq;
using System.Threading.Tasks;
using Core_Project.Domain;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            // Not implemented!
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Cliente[]> GetAllClientesAsync()
        {
            
            IQueryable<Cliente> query = _context.Clientes
                .Include(c => c.Produtos);

            query = query
                .AsNoTracking()
                .OrderByDescending(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Cliente> GetClienteAsyncById(int ClienteId)
        {
            IQueryable<Cliente> query = _context.Clientes
                .Include(c => c.Produtos);

            query = query
                .AsNoTracking()
                .OrderByDescending(c => c.Nome).Where(c => c.Id == ClienteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}