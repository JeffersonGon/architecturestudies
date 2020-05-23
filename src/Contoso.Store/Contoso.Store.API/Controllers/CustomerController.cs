using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constoso.Store.Application.Handlers.CustomerHandler;
using Contoso.Store.Domain.Contexts.Commands.Customer;
using Contoso.Store.Shared.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ICommandResult Get([FromBody] CreateCustomerCommand command)
        {
            return _handler.Handle(command);
        }
    }
}