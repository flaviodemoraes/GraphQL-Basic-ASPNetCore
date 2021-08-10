using System;
using System.Collections.Generic;
using GraphQL_Basic.IServices;

namespace GraphQL_Basic.Services
{
    public class Service<T> : IService<T>
    {
        public List<T> GetList()
        {
            List<T> lista = new List<T>();
            return lista;
        }
    }
}
