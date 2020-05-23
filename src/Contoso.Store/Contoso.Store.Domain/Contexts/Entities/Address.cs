using Contoso.Store.Domain.Contexts.Enums;
using Contoso.Store.Shared.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Domain.Contexts.Entities
{
    public class Address : Entity
    {
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string State { get; private set; }
        public string Country{ get; private set; }
        public EAddressType AddressType { get; private set; }

        public Address(string street, int number, string complement, 
            string district, string state, string country, EAddressType addressType)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            State = state;
            Country = country;
            AddressType = addressType;
        }

        public override string ToString()
        {
            return $"{Street}, {Number} {Complement} - {District} / {State}";
        }
    }
}
