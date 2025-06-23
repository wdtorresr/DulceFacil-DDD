using DulceFacil.Application.UseCases;
using DulceFacil.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DulceFacil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly CrearProductoUseCase _crear;
        private readonly ListarProductosUseCase _listar;
        private readonly ActualizarProductoUseCase _actualizar;
        private readonly EliminarProductoUseCase _eliminar;

        public ProductoController(
            CrearProductoUseCase crear,
            ListarProductosUseCase listar,
            ActualizarProductoUseCase actualizar,
            EliminarProductoUseCase eliminar)
        {
            _crear = crear;
            _listar = listar;
            _actualizar = actualizar;
            _eliminar = eliminar;
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Producto producto)
        {
            var resultado = await _crear.EjecutarAsync(producto);
            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var resultado = await _listar.EjecutarAsync();
            return Ok(resultado);
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(Producto producto)
        {
            await _actualizar.EjecutarAsync(producto);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(Producto producto)
        {
            await _eliminar.EjecutarAsync(producto);
            return NoContent();
        }
    }
}
