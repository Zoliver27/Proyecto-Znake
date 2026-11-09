using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaHistorialAct
    {
        public async Task<IEnumerable<HistorialAct_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<HistorialAct_Ent> repo = new Repositorio<HistorialAct_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<HistorialAct_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID no válido.");
            using var contexto = new AppDbContext();
            IRepositorio<HistorialAct_Ent> repo = new Repositorio<HistorialAct_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(HistorialAct_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Accion)) throw new Exception("La descripción de la actividad es obligatoria.");
            using var contexto = new AppDbContext();
            IRepositorio<HistorialAct_Ent> repo = new Repositorio<HistorialAct_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(HistorialAct_Ent entidad)
        {
            using var contexto = new AppDbContext();
            IRepositorio<HistorialAct_Ent> repo = new Repositorio<HistorialAct_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<HistorialAct_Ent> repo = new Repositorio<HistorialAct_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}