using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CarParking.Data.Repository
{
    public class AppRepository<Tentity> where Tentity : class
    {
        private readonly AppDbContext _dbcontext;

        public AppRepository(AppDbContext context)
        {

            _dbcontext = context;

        }

        public IQueryable<Tentity> GetByCondition(Expression<Func<Tentity, bool>> expression)
        {
            return _dbcontext.Set<Tentity>().Where(expression);
        }
      
        public IQueryable<Tentity> GetAll()
        {
            return _dbcontext.Set<Tentity>();
        }

        public IQueryable<Tentity> GetById(Expression<Func<Tentity, bool>> expression)
        {
            return _dbcontext.Set<Tentity>().Where(expression);
        }

        public void Create(Tentity entity)
        {
            _dbcontext.Set<Tentity>().Add(entity);
        }

        public void CreateRange(List<Tentity> entities)
        {
            _dbcontext.Set<Tentity>().AddRange(entities);
        }

        public void Delete(Tentity entity)
        {
            _dbcontext.Set<Tentity>().Remove(entity);
        }

        public void DeleteRange(List<Tentity> entities)
        {
            _dbcontext.Set<Tentity>().RemoveRange(entities);
        }

        public void Update(Tentity entity)
        {
            _dbcontext.Set<Tentity>().Update(entity);
        }

        public void UpdateRange(List<Tentity> entities)
        {
            _dbcontext.Set<Tentity>().UpdateRange(entities);
        }

    }
}
