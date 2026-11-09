using System.Collections.Generic;
using System.Threading.Tasks;
using Datos;
using Entidades_Znake;

namespace Logica_Znake
{
    public class LogicaProducto
    {
        public async Task<IEnumerable<Producto_Ent>> ObtenerTodosAsync()
        {
            using var contexto = new AppDbContext();
            IRepositorio<Producto_Ent> repo = new Repositorio<Producto_Ent>(contexto);
            return await repo.ObtenerTodosAsync();
        }

        public async Task<Producto_Ent?> ObtenerPorIdAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Producto_Ent> repo = new Repositorio<Producto_Ent>(contexto);
            return await repo.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Producto_Ent entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new Exception("El nombre del producto es obligatorio.");
            if (entidad.Precio <= 0) throw new Exception("El precio debe ser un número positivo mayor a 0.");
            if (entidad.Stock < 0) throw new Exception("El stock no puede ser un valor negativo.");
            if (entidad.Id_Marca <= 0) throw new Exception("Debe seleccionar una marca válida.");
            using var contexto = new AppDbContext();
            IRepositorio<Producto_Ent> repo = new Repositorio<Producto_Ent>(contexto);
            await repo.CrearAsync(entidad);
        }

        public async Task ActualizarAsync(Producto_Ent entidad)
        {
            if (entidad.Id_Productos <= 0) throw new Exception("ID de producto no válido.");
            if (entidad.Precio <= 0) throw new Exception("El precio debe ser mayor a cero.");
            if (entidad.Stock < 0) throw new Exception("El stock no puede ser negativo.");
            using var contexto = new AppDbContext();
            IRepositorio<Producto_Ent> repo = new Repositorio<Producto_Ent>(contexto);
            await repo.ActualizarAsync(entidad);
        }

        public async Task EliminarAsync(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            using var contexto = new AppDbContext();
            IRepositorio<Producto_Ent> repo = new Repositorio<Producto_Ent>(contexto);
            await repo.EliminarAsync(id);
        }
    }
}