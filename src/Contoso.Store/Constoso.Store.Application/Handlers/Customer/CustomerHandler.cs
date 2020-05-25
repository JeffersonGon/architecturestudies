using Constoso.Store.Application.Repositories.Dapper.Repositories;
using Contoso.Store.Domain.Contexts.Commands.Customer;
using Contoso.Store.Domain.Contexts.Entities;
using Contoso.Store.Domain.Contexts.Queries.CustomerQueries;
using Contoso.Store.Domain.Contexts.ValueObjects;
using Contoso.Store.Shared.Abstractions;
using Contoso.Store.Shared.Abstractions.Generic;
using Contoso.Store.Shared.Abstractions.Queries;
using Contoso.Store.Shared.Implementations;
using FluentValidator;
using System;

namespace Constoso.Store.Application.Handlers.CustomerHandler
{
    public class CustomerHandler : Notifiable, ICommandHandler<CreateCustomerCommand>, 
        IQueryHandler<GetCustomerQueryResult>, IQueryHandler<GetAllCustomersQueryResult>
    {
        private readonly ICustomerRepository _repository;

        public CustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public IResult Handle(CreateCustomerCommand command)
        {
            var name = new Name(command.Nome, command.Sobrenome);
            var cpf = new CPF(command.Documento);
            var email = new Email(command.Email);

            var customer = new Customer(name, cpf, email, command.Telefone);

            AddNotifications(name.Notifications);
            AddNotifications(cpf.Notifications);
            AddNotifications(email.Notifications);

            if (Invalid)
                return new BadRequestResult(false, "Error. Check properties values", Notifications);

            try
            {
                _repository.Save(customer);
            }
            catch(Exception ex)
            {
                return new ErrorResult(ex.Message, ex.InnerException);
            }

            return new CommandResult(true, "Customer created", null);
        }

        public IResult Handle(GetAllCustomersQueryResult query)
        {
            try
            {
                return new QueryResult(true, _repository.GetAll());
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message, ex.InnerException);
            }
        }

        public IResult Handle(GetCustomerQueryResult query)
        {
            try
            {
                var result = _repository.GetByCpf(query.Documento);

                if(result == null)
                    return new NotFoundResult("Customer not found", null);
                return new QueryResult(true, result);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message, ex.InnerException);
            }
        }
    }
}
