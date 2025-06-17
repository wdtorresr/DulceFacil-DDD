
using DulceFacil.Application.DTOs;
using DulceFacil.Domain.Entities;
using DulceFacil.Domain.Repositories;

namespace DulceFacil.Application.UseCases
{
    public class CrearProductoUseCase
    {
        private readonly IProductoRepository _repo;

        public CrearProductoUseCase(IProductoRepository repo)
        {
            _repo = repo;
        }

        public void Ejecutar(ProductoDTO dto)
        {
            var producto = new Producto
            {
                Id = Guid.NewGuid(),
                Nombre = dto.Nombre,
                Precio = dto.Precio
            };
            _repo.Agregar(producto);
        }
    }
}
