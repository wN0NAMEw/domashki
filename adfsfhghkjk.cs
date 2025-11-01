using System;
using System.Collections.Generic;

namespace chetonovoe
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product { Id = "P1", Name = "Ноутбук", Price = 50000, IsInStock = true };
            var product2 = new Product { Id = "P2", Name = "Мышь", Price = 1000, IsInStock = true };
            var product3 = new Product { Id = "P3", Name = "Клавиатура", Price = 2000, IsInStock = false };
            var customer = new Customer { Id = "C1", Name = "Иван Иванов", Email = "ivan@mail.ru" };

            var order = new Order
            {
                Id = "ORD-001",
                Customer = customer,
                Items = new List<OrderItem>
                {
                    new OrderItem { Product = product1, Quantity = 1 },
                    new OrderItem { Product = product2, Quantity = 2 }
                }
            };

            var stockValidator = new tovar();
            var discountApplier = new disco();
            var orderSaver = new save();
            var emailSender = new emaill();

            Console.WriteLine("=== Процесс оформления заказа ===");

            bool isInStock = stockValidator.ValidateStockAvailability(order);

            if (isInStock)
            {

                discountApplier.ApplyDiscountIfNeeded(order, true);

                orderSaver.SaveOrderToDatabase(order);

                emailSender.SendConfirmationEmail(order, customer);

                Console.WriteLine("Заказ успешно оформлен!");
            }
            else
            {
                Console.WriteLine("Заказ не может быть оформлен: недостаточно товара на складе.");
            }

            Console.ReadLine();
        }
    }
}
