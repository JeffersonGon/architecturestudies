using Contoso.Store.Domain.Contexts.ValueObjects;
using Contoso.Store.Shared.BaseEntity;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Store.Domain.Contexts.Entities
{
    public class Customer : Entity
    {
        private readonly IList<Address> _addresses;

        public Customer(Name name, CPF cPF, Email email, string telefone)
        {
            _addresses = new List<Address>();
            Name = name;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
        }

        public Name Name { get; private set; }
        public CPF CPF { get; private set; }
        public Email Email { get; private set; }
        public string Telefone { get; private set; }

        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
