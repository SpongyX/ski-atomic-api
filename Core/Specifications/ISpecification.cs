using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        //Expresion takes a function and the function takes a type, and what is returning it can be Criteria
        Expression<Func<T, bool>> Criteria { get; }

        //List take a generic expression and use function of type T and return generic object, can be includes operation
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, Object>> OrderBy { get; }

        Expression<Func<T, Object>> OrderByDescending { get; }

        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
