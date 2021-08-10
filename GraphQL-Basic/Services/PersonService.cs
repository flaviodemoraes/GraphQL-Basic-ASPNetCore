using System.Collections.Generic;
using GraphQL_Basic.IServices;
using GraphQL_Basic.Models;

namespace GraphQL_Basic.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetList()
        {
            List<Person> list = new List<Person>();

            for(int i = 1; i <= 5; i++)
            {
                list.Add(new Person()
                {
                    Name = "P" + i,
                    Age = 1 + i
                });
            }

            return list;
        }
    }
}
