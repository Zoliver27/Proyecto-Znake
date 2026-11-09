using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaUsuario
    {
        public async Task<IEnumerable<Usuario_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Usuario_Ent> repo = new Repositorio<Usuario_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Usuario_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new ArgumentException("El ID de usuario debe ser mayor a 0.");
            using var contexto = new AppDbContext();
            IRepositorio<Usuario_Ent> repo = new Repositorio<Usuario_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Usuario_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Usuario))
            {
                throw new Exception("El nombre de usuario es obligatorio.");

            }
            if (string.IsNullOrWhiteSpace(entidad.Password) || entidad.Password.Length < 4)
            {
                throw new Exception("La contraseña es obligatoria y debe tener al menos 4 caracteres.");

            }
            if (string.IsNullOrWhiteSpace(entidad.Rol))
            {
                throw new Exception("Debe asignar un rol al usuario.");

            }
            using var contexto = new AppDbContext();
            IRepositorio<Usuario_Ent> repo = new Repositorio<Usuario_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Usuario_Ent entidad)
        {
            if (entidad.Id_Usuario <= 0)
            {
                throw new Exception("ID de usuario no válido.");
            }
            if (string.IsNullOrWhiteSpace(entidad.Usuario))
            {
                throw new Exception("El nombre de usuario no puede estar vacío.");
            }
            using var contexto = new AppDbContext();
            IRepositorio<Usuario_Ent> repo = new Repositorio<Usuario_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0)
            {
                throw new Exception("El ID para eliminar debe ser válido.");
            }
            using var contexto = new AppDbContext();
            IRepositorio<Usuario_Ent> repo = new Repositorio<Usuario_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}