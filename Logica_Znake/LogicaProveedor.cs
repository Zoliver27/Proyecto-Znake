using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaProveedor
    {
        public async Task<IEnumerable<Proveedor_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Proveedor_Ent> repo = new Repositorio<Proveedor_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Proveedor_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Proveedor_Ent> repo = new Repositorio<Proveedor_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Proveedor_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre de la empresa proveedora es obligatorio.");
            if (string.IsNullOrWhiteSpace(entidad.Telefono)) throw new Exception("El teléfono del proveedor es obligatorio.");
            using var contexto = new AppDbContext();
            IRepositorio<Proveedor_Ent> repo = new Repositorio<Proveedor_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Proveedor_Ent entidad)
        {
            if (entidad.Id_Proveedor <= 0) throw new Exception("ID de proveedor inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Proveedor_Ent> repo = new Repositorio<Proveedor_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Proveedor_Ent> repo = new Repositorio<Proveedor_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}