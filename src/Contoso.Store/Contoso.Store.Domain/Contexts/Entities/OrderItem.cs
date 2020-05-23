﻿using Contoso.Store.Shared.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Domain.Contexts.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

            if (product.StockQuantity < quantity)
                AddNotification("Quantity", "Product out of stock!");

            product.WidthdrawStockQuantity(quantity);
        }

        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
