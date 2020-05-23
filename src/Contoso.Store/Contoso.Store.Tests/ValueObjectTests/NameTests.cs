using Contoso.Store.Domain.Contexts.ValueObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Tests.ValueObjectTests
{
    public class NameTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void NameTests_IsValid_ReturnTrue()
        {
            var name = new Name("Jefferson", "Almeida");
            Assert.AreEqual(true, name.IsValid);
        }

        [Test]
        public void NameTests_Invalid_ReturnTrue()
        {
            var name = new Name("Je", "Al");
            Assert.AreEqual(true, name.Invalid);
        }
    }
}
