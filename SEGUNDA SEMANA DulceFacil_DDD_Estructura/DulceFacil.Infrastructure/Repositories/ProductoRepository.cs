
using DulceFacil.Domain.Entities;
using DulceFacil.Domain.Repositories;

namespace DulceFacil.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private static readonly List<Producto> _db = new();

        public void Agregar(Producto producto) => _db.Add(producto);
        public Producto ObtenerPorId(Guid id) => _db.FirstOrDefault(p => p.Id == id);
        public IEnumerable<Producto> ObtenerTodos() => _db;
    }
}
