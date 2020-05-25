using Contoso.Store.Shared.Abstractions;
using Contoso.Store.Shared.Abstractions.Queries;
using FluentValidator;
using FluentValidator.Validation;

namespace Contoso.Store.Domain.Contexts.Queries.CustomerQueries
{
    public class GetCustomerQueryResult : Notifiable, IQuery
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public bool IsValidResult()
        {
            AddNotifications(new ValidationContract()
                .AreEquals(false, string.IsNullOrEmpty(Nome), "Name", "O campo name está vazio")
                .AreEquals(false, string.IsNullOrEmpty(Telefone), "Telefone", "O campo telefone está vazio")
                .AreEquals(false, string.IsNullOrEmpty(Email), "Email", "O campo name está vazio")
                .AreEquals(false, string.IsNullOrEmpty(Documento), "Documento", "O CPF está vazio"));
            return IsValid;
        }
    }
}
