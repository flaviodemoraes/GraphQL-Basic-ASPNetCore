using System;
using System.Collections.Generic;

namespace GraphQL_Basic.IServices
{
    public interface IService<T>
    {
        List<T> GetList();
    }
}
