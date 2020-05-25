using Constoso.Store.Application.Handlers.CustomerHandler;
using Contoso.Store.Domain.Contexts.Commands.Customer;
using Contoso.Store.Domain.Contexts.Queries.CustomerQueries;
using Contoso.Store.Shared.Abstractions;
using Contoso.Store.Shared.Abstractions.Generic;
using Contoso.Store.Shared.Abstractions.HttpResults;
using Contoso.Store.Shared.Abstractions.Queries;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Contoso.Store.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly CustomerHandler _handler;

        public CustomerController(CustomerHandler handler)
        {
            _handler = handler;
        }

        //[HttpGet]
        //[Route("")]
        //[ProducesResponseType(typeof(string), 200)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(500)]
        //public IQueryResult Get()
        //{
        //    return _handler.Handle();
        //}

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(IQueryResult), 200)]
        [ProducesResponseType(typeof(INotFoundResult), 404)]
        [ProducesResponseType(typeof(IErrorResult), 500)]
        public IResult Get()
        {
            return _handler.Handle(new GetAllCustomersQueryResult());
        }

        [HttpGet("{cpf}")]
        [Route("")]
        [ProducesResponseType(typeof(IQueryResult), 200)]
        [ProducesResponseType(typeof(INotFoundResult), 404)]
        [ProducesResponseType(typeof(IErrorResult), 500)]
        public IResult GetByCpf([FromRoute]string cpf)
        {
            var query = new GetCustomerQueryResult { Documento = cpf };
            return _handler.Handle(query);
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(ICommandResult), 200)]
        [ProducesResponseType(typeof(IBadRequestResult), 400)]
        [ProducesResponseType(typeof(IErrorResult), 500)]
        public IResult Post([FromBody] CreateCustomerCommand command)
        {
            return _handler.Handle(command);
        }

    }
}
