
using DulceFacil.Domain.Entities;

namespace DulceFacil.Domain.Repositories
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);
        Producto ObtenerPorId(Guid id);
        IEnumerable<Producto> ObtenerTodos();
    }
}
