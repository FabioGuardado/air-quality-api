using Sensores.Domain.Entities;
using Sensores.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Sensores.Infrastructure.Persistence.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            var result = await _context.SaveChangesAsync();

            if (result == 0 || entity.Id == 0)
            {
                return null;
            }

            return entity;
        }

        public virtual async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public virtual async Task<TEntity?> FindFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<bool> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null)
            {
                return false;
            }

            entity.IsDeleted = true;
            return await _context.SaveChangesAsync() > 0;
        }

        public virtual async Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate, int take, int page, string search)
        {
            var skip = (page - 1) * take;
            var query = _context.Set<TEntity>().Where(predicate);

            return query.Skip(skip).Take(take).AsQueryable();
        }
    }
}
