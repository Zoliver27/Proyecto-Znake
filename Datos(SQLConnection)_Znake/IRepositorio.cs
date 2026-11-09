using System.Collections.Generic;
using System.Threading.Tasks;

namespace Datos
{
    public interface IRepositorio<T> where T : class
    {
        Task<IEnumerable<T>> ObtenerTodosAsync();
        Task<T?> ObtenerPorIdAsync(int id);
        Task CrearAsync(T entidad);
        Task ActualizarAsync(T entidad);
        Task EliminarAsync(int id);
    }
}