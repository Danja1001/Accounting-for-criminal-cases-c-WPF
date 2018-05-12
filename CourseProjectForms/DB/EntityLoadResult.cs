using System;
using System.Linq.Expressions;
using CourseProjectForms.DB.Interfaces;


namespace CourseProjectForms.DB
{
    public class EntityLoadResult<TInput> : ILoadable<TInput>
        where TInput : class
    {
        private readonly IRepository _repository;

        private readonly TInput _resultOfPreviousCall;

        public EntityLoadResult(IRepository repository, TInput resultOfPreviousCall)
        {
            _repository = repository;
            _resultOfPreviousCall = resultOfPreviousCall;
        }

        public ILoadable<TElement> ThenLoadRelated<TElement>(Expression<Func<TInput, TElement>> expression) where TElement : class
        {
            if (_resultOfPreviousCall == null)
            {
                return new EntityLoadResult<TElement>(_repository, null);
            }

            return _repository.LoadRelated(_resultOfPreviousCall, expression);
        }
    }
}