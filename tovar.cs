using System;
using System.Linq;

namespace chetonovoe
{
    public class tovar
    {
        public bool ValidateStockAvailability(Order order) 
        {
            Console.WriteLine($"Проверка наличия товара на складе для заказа: {order.Id}");

            bool allInStock = order.Items.All(item => item.Product.IsInStock);

            if (allInStock)
            {
                Console.WriteLine("Все товары в наличии.");
            }
            else
            {
                Console.WriteLine("Некоторые товары отсутствуют на складе.");
            }

            return allInStock;
        }
    }
}