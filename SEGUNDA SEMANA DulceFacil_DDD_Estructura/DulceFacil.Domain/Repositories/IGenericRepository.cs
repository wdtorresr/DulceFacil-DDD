using System.Collections.Generic;
using System.Threading.Tasks;

namespace DulceFacil.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CrearAsync(T entidad);
        Task<List<T>> ListarAsync();
        Task<T?> BuscarPorIdAsync(object id);
        Task ActualizarAsync(T entidad);
        Task EliminarAsync(T entidad);
    }
}
