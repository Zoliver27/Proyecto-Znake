using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaDetalleCarrito
    {
        public async Task<IEnumerable<DetalleCarrito_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCarrito_Ent> repo = new Repositorio<DetalleCarrito_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<DetalleCarrito_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCarrito_Ent> repo = new Repositorio<DetalleCarrito_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(DetalleCarrito_Ent entidad)
        {
            if (entidad.Cantidad <= 0) throw new Exception("La cantidad agregada al carrito debe ser al menos 1.");
            if (entidad.Id_Producto <= 0) throw new Exception("Debe asociar un producto válido al carrito.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCarrito_Ent> repo = new Repositorio<DetalleCarrito_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(DetalleCarrito_Ent entidad)
        {
            if (entidad.Id_Detalle_Carrito <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCarrito_Ent> repo = new Repositorio<DetalleCarrito_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCarrito_Ent> repo = new Repositorio<DetalleCarrito_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}