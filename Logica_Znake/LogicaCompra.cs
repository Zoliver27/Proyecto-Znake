using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaCompra
    {
        public async Task<IEnumerable<Compra_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Compra_Ent> repo = new Repositorio<Compra_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Compra_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de compra no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Compra_Ent> repo = new Repositorio<Compra_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Compra_Ent entidad)
        {
            if (entidad.Id_Proveedor <= 0) throw new Exception("Debe asociar un proveedor a la compra.");
            if (entidad.Total <= 0) throw new Exception("El monto total de la compra debe ser mayor a cero.");
            using var contexto = new AppDbContext();
            IRepositorio<Compra_Ent> repo = new Repositorio<Compra_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Compra_Ent entidad)
        {
            if (entidad.Id_Compras <= 0) throw new Exception("ID de compra inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Compra_Ent> repo = new Repositorio<Compra_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de compra inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Compra_Ent> repo = new Repositorio<Compra_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}