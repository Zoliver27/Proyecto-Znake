using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaVendedor
    {
        public async Task<IEnumerable<Vendedor_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Vendedor_Ent> repo = new Repositorio<Vendedor_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Vendedor_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Vendedor_Ent> repo = new Repositorio<Vendedor_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Vendedor_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre del vendedor es obligatorio.");
            if (entidad.Id_Usuario <= 0) throw new Exception("Debe asociarse a un ID de usuario válido.");
            using var contexto = new AppDbContext();
            IRepositorio<Vendedor_Ent> repo = new Repositorio<Vendedor_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Vendedor_Ent entidad)
        {
            if (entidad.Id_Vendedor <= 0) throw new Exception("ID de vendedor inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Vendedor_Ent> repo = new Repositorio<Vendedor_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Vendedor_Ent> repo = new Repositorio<Vendedor_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}