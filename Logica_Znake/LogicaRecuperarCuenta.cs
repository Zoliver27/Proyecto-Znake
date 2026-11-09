using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaRecuperarCuenta
    {
        public async Task<IEnumerable<RecuperarCuenta_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<RecuperarCuenta_Ent> repo = new Repositorio<RecuperarCuenta_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<RecuperarCuenta_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<RecuperarCuenta_Ent> repo = new Repositorio<RecuperarCuenta_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(RecuperarCuenta_Ent entidad)
        {
            if (entidad.Id_Usuario <= 0) throw new Exception("Debe asociar un usuario válido.");
            using var contexto = new AppDbContext();
            IRepositorio<RecuperarCuenta_Ent> repo = new Repositorio<RecuperarCuenta_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(RecuperarCuenta_Ent entidad)
        {
            using var contexto = new AppDbContext();
            IRepositorio<RecuperarCuenta_Ent> repo = new Repositorio<RecuperarCuenta_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<RecuperarCuenta_Ent> repo = new Repositorio<RecuperarCuenta_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}