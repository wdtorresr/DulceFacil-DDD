using DulceFacil.Domain.Entities;
using DulceFacil.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DulceFacil.Infrastructure.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(DbContext context) : base(context)
        {
        }
    }
}
