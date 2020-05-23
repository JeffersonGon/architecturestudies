using Contoso.Store.Domain.Contexts.ValueObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Tests.ValueObjectTests
{
    public class CPFTests
    {
        private CPF _cpfValido;
        private CPF _cpfInvalido;

        [SetUp]
        public void Setup()
        {
            _cpfValido = new CPF("75617067079");
            _cpfInvalido = new CPF("00011111179");
        }

        [Test]
        public void CPFTest_IsValid_ReturnTrue()
        {
            Assert.AreEqual(true, _cpfValido.IsValid);
        }

        [Test]
        public void CpfTest_Invalid_ReturnFalse()
        {
            Assert.AreEqual(true, _cpfInvalido.Invalid);
        }
    }
}
