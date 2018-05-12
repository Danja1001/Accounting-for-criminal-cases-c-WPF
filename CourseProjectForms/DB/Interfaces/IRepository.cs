using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace CourseProjectForms.DB.Interfaces
{
    public interface ILoadable<TInput> where TInput : class
    {
        ILoadable<TElement> ThenLoadRelated<TElement>(Expression<Func<TInput, TElement>> property) where TElement : class;
    }


    public interface IRepository
    {
        DatabaseContext DataContext { get; }
        IRepositoryOf<T> Of<T>() where T : class;
        bool IsLoaded<TInput, TElement>(TInput entity, Expression<Func<TInput, ICollection<TElement>>> navigationProperty) where TElement : class where TInput : class;
        bool IsLoaded<TInput, TElement>(TInput entity, Expression<Func<TInput, TElement>> property) where TElement : class where TInput : class;
        void LoadRelated<TInput, TElement>(TInput entity, Expression<Func<TInput, ICollection<TElement>>> navigationProperty) where TElement : class where TInput : class;
        ILoadable<TElement> LoadRelated<TInput, TElement>(TInput entity, Expression<Func<TInput, TElement>> property) where TElement : class where TInput : class;
        int SaveChanges();
    }

    public interface IRepositoryOf<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> Search(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[] includes);
        IQueryable<T> Search(Expression<Func<T, bool>> predicate, string[] includes);
        IQueryable<T> Search(Expression<Func<T, bool>> predicate);
        T GetById(Int32 id);
        bool IsModified(T objectToTrackChanges, Expression<Func<T, object>> expression);
        object GetById(object lawyerId);
    }
}