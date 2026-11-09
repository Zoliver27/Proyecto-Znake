using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly AppDbContext _contexto;
        private readonly DbSet<T> _dbSet;

        public Repositorio(AppDbContext contexto)
        {
            _contexto = contexto;
            _dbSet = _contexto.Set<T>();
        }

        public async Task<IEnumerable<T>> ObtenerTodosAsync() => await _dbSet.ToListAsync();
        public async Task<T?> ObtenerPorIdAsync(int id) => await _dbSet.FindAsync(id);
        public async Task CrearAsync(T entidad)
        {
            await _dbSet.AddAsync(entidad);
            await _contexto.SaveChangesAsync();
        }
        public async Task ActualizarAsync(T entidad)
        {
            _dbSet.Update(entidad);
            await _contexto.SaveChangesAsync();
        }
        public async Task EliminarAsync(int id)
        {
            var entidad = await _dbSet.FindAsync(id);
            if (entidad != null)
            {
                _dbSet.Remove(entidad);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}