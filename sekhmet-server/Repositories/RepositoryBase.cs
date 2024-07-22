using System.Linq.Expressions;
using sekhmet_server.Repositories.Interfaces;
using sekhmet_server.Models;
using Microsoft.EntityFrameworkCore;

namespace sekhmet_server.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected SekhmetContext SekhmetContext { get; set; }

        public RepositoryBase(SekhmetContext sekhmetContext)
        {
            this.SekhmetContext = sekhmetContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.SekhmetContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.SekhmetContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.SekhmetContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.SekhmetContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.SekhmetContext.Set<T>().Remove(entity);
        }
    }
}