using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CourseProjectForms.DB.Interfaces;


namespace CourseProjectForms.DB
{
    public class RepositoryComposition : IRepository
    {
        public DatabaseContext DataContext { get; }

        private readonly Dictionary<Type, Object> _subRepositories;

        public RepositoryComposition(DatabaseContext dataContext)
        {
            _subRepositories = new Dictionary<Type, object>();
            DataContext = dataContext;
        }

        public int SaveChanges()
        {
            return DataContext.SaveChanges();
        }

        public bool IsNew<TInput>(TInput entity) where TInput : class
        {
            return DataContext.Entry(entity).State == EntityState.Added;
        }

        public bool IsLoaded<TInput, TElement>(TInput entity, Expression<Func<TInput, ICollection<TElement>>> expression)
            where TElement : class
            where TInput : class
        {
            return DataContext.Entry(entity).Collection(expression).IsLoaded;
        }

        public bool IsLoaded<TInput, TProperty>(TInput entity, Expression<Func<TInput, TProperty>> expression)
            where TProperty : class
            where TInput : class
        {
            return DataContext.Entry(entity).Reference(expression).IsLoaded;
        }

        public void LoadRelated<TInput, TElement>(TInput entity, Expression<Func<TInput, ICollection<TElement>>> expression) where TInput : class where TElement : class
        {
            if (IsLoaded(entity, expression) || IsNew(entity))
            {
                return;
            }

            DataContext.Entry(entity).Collection(expression).Load();
        }

        public ILoadable<TElement> LoadRelated<TInput, TElement>(TInput entity, Expression<Func<TInput, TElement>> expression) where TInput : class where TElement : class
        {
            if (IsLoaded(entity, expression) || IsNew(entity))
            {
                return new EntityLoadResult<TElement>(this, null);
            }

            DataContext.Entry(entity).Reference(expression).Load();

            var result = (TElement)expression.Compile().DynamicInvoke(entity);

            return new EntityLoadResult<TElement>(this, result);
        }

        public IRepositoryOf<T> Of<T>() where T : class
        {
            var type = typeof(T);

            if (!_subRepositories.ContainsKey(type))
            {
                var subRepository = new GenericRepository<T>(DataContext);
                _subRepositories.Add(type, subRepository);
                return subRepository;
            }

            return (IRepositoryOf<T>)_subRepositories[type];
        }

        public class GenericRepository<T> : IRepositoryOf<T> where T : class
        {
            private readonly DbSet<T> _dbSet;

            private readonly DatabaseContext _dataContext;

            public GenericRepository(DatabaseContext dataContext)
            {
                _dataContext = dataContext;
                _dbSet = dataContext.Set<T>();
            }

            public void Insert(T entity)
            {
                _dbSet.Add(entity);
            }

            public void Delete(T entity)
            {
                _dbSet.Remove(entity);
            }

            public IQueryable<T> GetAll()
            {
                return _dbSet;
            }

            public virtual IQueryable<T> Search(Expression<Func<T, bool>> predicate)
            {
                return _dbSet.Where(predicate);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="predicate"></param>
            /// <param name="includes">Load the related entities listed here.</param>
            /// <returns></returns>
            public virtual IQueryable<T> Search(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[] includes)
            {
                IQueryable<T> dataset = _dbSet;

                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        dataset = dataset.Include(include);
                    }
                }

                var items = dataset.Where(predicate);

                return items;
            }

            public virtual IQueryable<T> Search(Expression<Func<T, bool>> predicate, string[] includes)
            {
                IQueryable<T> itemWithIncludes = _dbSet;

                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        itemWithIncludes = itemWithIncludes.Include(include);
                    }
                }

                var items = itemWithIncludes.Where(predicate);

                return items;
            }

            public T GetById(Int32 id)
            {
                return _dbSet.Find(id);
            }

            public bool IsModified(T objectToTrackChanges, Expression<Func<T, object>> expression)
            {
                var entry = _dataContext.ChangeTracker
                    .Entries()
                    .FirstOrDefault(p => p.State == EntityState.Modified && p.Entity == objectToTrackChanges);

                if (entry == null)
                {
                    return false;
                }

                var body = expression.Body as MemberExpression;
                if (body == null)
                {
                    body = ((UnaryExpression)expression.Body).Operand as MemberExpression;
                }
                var propertyName = body.Member.Name;

                var originalValue = entry.OriginalValues[propertyName].ToString();
                var currentValue = entry.CurrentValues[propertyName].ToString();

                return originalValue != currentValue;
            }

            public object GetById(object lawyerId)
            {
                throw new NotImplementedException();
            }
        }
    }
}