using DulceFacil.Domain.Entities;
using DulceFacil.Domain.Repositories;

namespace DulceFacil.Application.UseCases
{
    public class EliminarProductoUseCase
    {
        private readonly IProductoRepository _repositorio;

        public EliminarProductoUseCase(IProductoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task EjecutarAsync(Producto producto)
        {
            await _repositorio.EliminarAsync(producto);
        }
    }
}
