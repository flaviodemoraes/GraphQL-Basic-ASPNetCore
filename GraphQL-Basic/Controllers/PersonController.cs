using System;
using System.Collections.Generic;
using GraphQL_Basic.IServices;
using GraphQL_Basic.Models;

namespace GraphQL_Basic.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public List<Person> Persons => _personService.GetList();
    }
}
