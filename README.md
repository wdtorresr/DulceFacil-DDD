# DulceFacil-DDD 🍬

Proyecto académico basado en **arquitectura DDD (Domain-Driven Design)** combinada con **DIP (Dependency Inversion Principle)**.  
Diseñado para estructurar un sistema de gestión de productos de una dulcería con buenas prácticas de desarrollo.

---

## 📁 Estructura del Proyecto

```plaintext
DulceFacil.Domain
├── Entities
│   └── Producto.cs
├── Repositories
│   └── IProductoRepository.cs

DulceFacil.Application
├── DTOs
│   └── ProductoDTO.cs
├── UseCases
│   └── CrearProductoUseCase.cs

DulceFacil.Infrastructure
└── Repositories
    └── ProductoRepository.cs

DulceFacil.API
└── Controllers
    └── ProductoController.cs
