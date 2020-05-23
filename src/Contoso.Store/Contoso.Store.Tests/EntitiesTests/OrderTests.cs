using Contoso.Store.Domain.Contexts.Entities;
using Contoso.Store.Domain.Contexts.Enums;
using Contoso.Store.Domain.Contexts.ValueObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Tests.EntitiesTests
{
    public class OrderTests
    {
        private Product _teclado;
        private Product _mouse;
        private Product _monitor;
        private Customer _customer;
        private Order _order;

        [SetUp]
        public void Setup()
        {
            //Simular dados reais
            var name = new Name("Jefferson", "Almeida");
            var cpf = new CPF("75617067079");
            var email = new Email("jeffersongoncalves473@gmail.com");

            _teclado = new Product("Teclado", "", "teclado.jpeg", 10M, 10);
            _mouse = new Product("Mouse", "", "mouse.jpeg", 4M, 10);
            _monitor = new Product("Monitor", "", "monitor.jpeg", 50M, 10);

            _customer = new Customer(name, cpf, email, "(11) 95555-5555");
            _order = new Order(_customer);
        }

        [Test]
        public void OrderTests_CreateOrder_WhenValid_ReturnTrue()
        {
            Assert.AreEqual(true, _order.IsValid);
        }

        [Test]
        public void OrderTests_CreateOrder_WhenCreated_Status_IsCreated()
        {
            Assert.AreEqual(EOrderStatus.Created, _order.Status);
        }

        [Test]
        public void OrderTests_CreateOrder_Order_Item_Must_br_2()
        {
            _order.AddItem(_monitor, 5);
            _order.AddItem(_teclado, 5);

            Assert.AreEqual(2, _order.Itens.Count);
        }

        [Test]
        public void OrderTests_AddItem_Should_Subtract_5_From_Stock()
        {
            _order.AddItem(_monitor, 5);

            Assert.AreEqual(5, _monitor.StockQuantity);
        }

        [Test]
        public void OrderTests_Create_Order_Should_Have_Two_Shipings_If_Higher_Than_Five()
        {
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.Ship();

            Assert.AreEqual(2, _order.Deliveries.Count);
        }
    }
}
