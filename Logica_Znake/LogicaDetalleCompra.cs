using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaDetalleCompra
    {
        public async Task<IEnumerable<DetalleCompra_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCompra_Ent> repo = new Repositorio<DetalleCompra_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<DetalleCompra_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCompra_Ent> repo = new Repositorio<DetalleCompra_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(DetalleCompra_Ent entidad)
        {
            if (entidad.Cantidad <= 0) throw new Exception("La cantidad comprada debe ser al menos 1.");
            if (entidad.Precio <= 0) throw new Exception("El precio unitario debe ser positivo.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCompra_Ent> repo = new Repositorio<DetalleCompra_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(DetalleCompra_Ent entidad)
        {
            if (entidad.Id_Detalle <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCompra_Ent> repo = new Repositorio<DetalleCompra_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<DetalleCompra_Ent> repo = new Repositorio<DetalleCompra_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}