using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaMarca
    {
        public async Task<IEnumerable<Marca_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Marca_Ent> repo = new Repositorio<Marca_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Marca_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de marca no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Marca_Ent> repo = new Repositorio<Marca_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Marca_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre de la marca no puede ir vacío.");
            using var contexto = new AppDbContext();
            IRepositorio<Marca_Ent> repo = new Repositorio<Marca_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Marca_Ent entidad)
        {
            if (entidad.Id_Marca <= 0) throw new Exception("ID de marca inválido.");
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre de la marca es obligatorio.");
            using var contexto = new AppDbContext();
            IRepositorio<Marca_Ent> repo = new Repositorio<Marca_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Marca_Ent> repo = new Repositorio<Marca_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}