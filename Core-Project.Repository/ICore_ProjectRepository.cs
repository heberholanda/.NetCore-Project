using System.Threading.Tasks;
using Core_Project.Domain;

namespace Core_Project.Repository
{
    public interface ICore_ProjectRepository
    {
        // Generic Repository Pattern
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<Cliente[]> GetAllClientesAsync();
        Task<Cliente> GetClienteAsyncById(int ClienteId);

    }
}