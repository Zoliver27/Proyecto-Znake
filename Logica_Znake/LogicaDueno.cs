using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaDueno
    {
        public async Task<IEnumerable<Dueno_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Dueno_Ent> repo = new Repositorio<Dueno_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Dueno_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Dueno_Ent> repo = new Repositorio<Dueno_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Dueno_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre del dueño es obligatorio.");
            if (entidad.Id_Usuario <= 0) throw new Exception("Debe asociar un ID de usuario válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Dueno_Ent> repo = new Repositorio<Dueno_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Dueno_Ent entidad)
        {
            if (entidad.Id_Dueno <= 0) throw new Exception("ID de dueño no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Dueno_Ent> repo = new Repositorio<Dueno_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Dueno_Ent> repo = new Repositorio<Dueno_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}
