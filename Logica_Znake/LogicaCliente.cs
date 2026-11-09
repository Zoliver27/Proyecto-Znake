using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaCliente
    {
        public async Task<IEnumerable<Cliente_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Cliente_Ent> repo = new Repositorio<Cliente_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Cliente_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de cliente inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Cliente_Ent> repo = new Repositorio<Cliente_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Cliente_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre del cliente es obligatorio.");
            using var contexto = new AppDbContext();
            IRepositorio<Cliente_Ent> repo = new Repositorio<Cliente_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Cliente_Ent entidad)
        {
            if (entidad.Id_Clientes <= 0) throw new Exception("ID de cliente no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Cliente_Ent> repo = new Repositorio<Cliente_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de cliente no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Cliente_Ent> repo = new Repositorio<Cliente_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}