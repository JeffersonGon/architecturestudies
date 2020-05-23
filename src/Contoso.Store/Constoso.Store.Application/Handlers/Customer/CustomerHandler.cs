using Constoso.Store.Application.Repositories.Dapper.Repositories;
using Contoso.Store.Domain.Contexts.Commands.Customer;
using Contoso.Store.Domain.Contexts.Entities;
using Contoso.Store.Domain.Contexts.ValueObjects;
using Contoso.Store.Shared.Abstractions;
using Contoso.Store.Shared.Implementations;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Constoso.Store.Application.Handlers.CustomerHandler
{
    public class CustomerHandler : Notifiable, ICommandHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository _repository;

        public CustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateCustomerCommand command)
        {
            var name = new Name(command.Nome, command.Sobrenome);
            var cpf = new CPF(command.Documento);
            var email = new Email(command.Email);

            var customer = new Customer(name, cpf, email, command.Telefone);

            AddNotifications(name.Notifications);
            AddNotifications(cpf.Notifications);
            AddNotifications(email.Notifications);

            if (Invalid)
                return new CommandResult(false, "Invalid", Notifications);

            try
            {
                _repository.Save(customer, 0);
            }
            catch(Exception ex)
            {
                //TO-DO: Implementar log real
                throw new Exception("Erro - Handler CustomerHandler" + ex.InnerException);
            }

            return new CommandResult(true, "Customer created.", null);
        }
    }
}
