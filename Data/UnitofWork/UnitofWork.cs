using System.Collections;
using CarParking.Data.Repository;

namespace CarParking.Data.UnitofWork
{
    public class UnitofWork
    {
        private readonly AppDbContext _context;
        private Hashtable _repositories;

        public UnitofWork(AppDbContext context)
        {
            _context = context;
        }

        public bool Complete()
        {
           var numberOfAffectedRows = _context.SaveChanges();
           
            return numberOfAffectedRows > 0;
        }


        public AppRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null) _repositories = new Hashtable();

            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(AppRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (AppRepository<TEntity>)_repositories[type];
        }
    }

}

