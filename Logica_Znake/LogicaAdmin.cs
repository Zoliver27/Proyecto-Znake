using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaAdmin
    {
        public async Task<IEnumerable<Admin_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Admin_Ent> repo = new Repositorio<Admin_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Admin_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Admin_Ent> repo = new Repositorio<Admin_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Admin_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre del administrador es obligatorio.");
            if (entidad.Id_Usuario <= 0) throw new Exception("Debe asociarse a un usuario válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Admin_Ent> repo = new Repositorio<Admin_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Admin_Ent entidad)
        {
            if (entidad.Id_Admin <= 0) throw new Exception("ID de administrador no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Admin_Ent> repo = new Repositorio<Admin_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID de administrador inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Admin_Ent> repo = new Repositorio<Admin_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}