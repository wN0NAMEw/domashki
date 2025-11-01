using System;

namespace chetonovoe
{
    public class save
    {
        public bool SaveOrderToDatabase(Order order)
        {
            Console.WriteLine("Сохранение заказа в базу данных...");
            order.Status = OrderStatus.Created;
            Console.WriteLine($"Заказ сохранен с ID: {order.Id}");
            return true;
        }
    }
}