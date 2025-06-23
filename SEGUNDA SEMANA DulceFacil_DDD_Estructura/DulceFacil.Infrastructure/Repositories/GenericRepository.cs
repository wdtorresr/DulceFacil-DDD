using DulceFacil.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DulceFacil.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> CrearAsync(T entidad)
        {
            await _dbSet.AddAsync(entidad);
            await _context.SaveChangesAsync();
            return entidad;
        }

        public async Task<List<T>> ListarAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> BuscarPorIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task ActualizarAsync(T entidad)
        {
            _dbSet.Update(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(T entidad)
        {
            _dbSet.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }
}
