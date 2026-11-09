using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaVenta
    {
        public async Task<IEnumerable<Venta_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Venta_Ent> repo = new Repositorio<Venta_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Venta_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de venta no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Venta_Ent> repo = new Repositorio<Venta_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Venta_Ent entidad)
        {
            if (entidad.Id_Cliente <= 0) throw new Exception("Debe seleccionar un cliente para registrar la venta.");
            if (entidad.Total <= 0) throw new Exception("El monto total de la venta debe ser mayor a cero.");
            using var contexto = new AppDbContext();
            IRepositorio<Venta_Ent> repo = new Repositorio<Venta_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Venta_Ent entidad)
        {
            if (entidad.Id_Ventas <= 0) throw new Exception("ID de venta no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Venta_Ent> repo = new Repositorio<Venta_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de venta no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Venta_Ent> repo = new Repositorio<Venta_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}