
using Microsoft.AspNetCore.Mvc;
using DulceFacil.Application.DTOs;
using DulceFacil.Application.UseCases;
using DulceFacil.Domain.Repositories;

namespace DulceFacil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly CrearProductoUseCase _useCase;

        public ProductoController(IProductoRepository repo)
        {
            _useCase = new CrearProductoUseCase(repo);
        }

        [HttpPost]
        public IActionResult Crear(ProductoDTO dto)
        {
            _useCase.Ejecutar(dto);
            return Ok("Producto creado correctamente");
        }
    }
}
