using DulceFacil.Domain.Entities;
using DulceFacil.Domain.Repositories;

namespace DulceFacil.Application.UseCases
{
    public class ListarProductosUseCase
    {
        private readonly IProductoRepository _repositorio;

        public ListarProductosUseCase(IProductoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Producto>> EjecutarAsync()
        {
            return await _repositorio.ListarAsync();
        }
    }
}
