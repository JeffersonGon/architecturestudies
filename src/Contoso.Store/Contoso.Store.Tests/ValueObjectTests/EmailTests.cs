using Contoso.Store.Domain.Contexts.ValueObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Tests.ValueObjectTests
{
    public class EmailTests
    {
        private Email _emailInvalido;
        private Email _emailValido;

        [SetUp]
        public void Setup()
        {
            _emailInvalido = new Email("jefferson.almeida.com.br");
            _emailValido = new Email("jefferson.almeida@konia.com.br");
        }

        [Test]
        public void EmailTest_Invalid_ReturnFalse()
        {
            Assert.AreEqual(true, _emailInvalido.Invalid);
        }

        [Test]
        public void EmailTest_Valid_ReturnTrue()
        {
            Assert.AreEqual(true, _emailValido.IsValid);
        }
    }
}
