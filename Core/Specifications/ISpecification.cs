using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    //to build specifications for IQueryable to query the table
    public interface ISpecification<T>
    {
        //SQL WHERE
         Expression<Func<T, bool>> Criteria {get;}
        
        //SQL AND 
         List<Expression<Func<T,object>>> Includes {get;}
    }
}