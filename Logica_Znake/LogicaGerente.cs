using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaGerente
    {
        public async Task<IEnumerable<Gerente_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Gerente_Ent> repo = new Repositorio<Gerente_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Gerente_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Gerente_Ent> repo = new Repositorio<Gerente_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Gerente_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre del gerente es obligatorio.");
            if (entidad.Id_Usuario <= 0) throw new Exception("ID de usuario no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Gerente_Ent> repo = new Repositorio<Gerente_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Gerente_Ent entidad)
        {
            if (entidad.Id_Gerente <= 0) throw new Exception("ID de gerente inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Gerente_Ent> repo = new Repositorio<Gerente_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Gerente_Ent> repo = new Repositorio<Gerente_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}