using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Domain.Contexts.ValueObjects
{
    public class Name : Notifiable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(FirstName, 3, "FirstName", "Esta campo deve conter ao mínimo 3 caracteres")
                .HasMaxLen(FirstName, 20, "FirstName", "Este campo deve conter no máximo 20 caracteres")
                .HasMinLen(LastName, 3, "LastName", "Esta campo deve conter ao mínimo 3 caracteres")
                .HasMaxLen(LastName, 20, "LastName", "Este campo deve conter no máximo 20 caracteres"));
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
