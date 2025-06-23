using DulceFacil.Domain.Entities;
using DulceFacil.Domain.Repositories;

namespace DulceFacil.Application.UseCases
{
    public class ActualizarProductoUseCase
    {
        private readonly IProductoRepository _repositorio;

        public ActualizarProductoUseCase(IProductoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task EjecutarAsync(Producto producto)
        {
            await _repositorio.ActualizarAsync(producto);
        }
    }
}
