using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaCarrito
    {
        public async Task<IEnumerable<Carrito_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Carrito_Ent> repo = new Repositorio<Carrito_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Carrito_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de carrito inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Carrito_Ent> repo = new Repositorio<Carrito_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Carrito_Ent entidad)
        {
            if (entidad.Id_Cliente <= 0) throw new Exception("El carrito debe pertenecer a un cliente válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Carrito_Ent> repo = new Repositorio<Carrito_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Carrito_Ent entidad)
        {
            if (entidad.Id_Carrito <= 0) throw new Exception("ID de carrito no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Carrito_Ent> repo = new Repositorio<Carrito_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Carrito_Ent> repo = new Repositorio<Carrito_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}