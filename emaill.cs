using System;

namespace chetonovoe
{
    public class emaill
    {
        public void SendConfirmationEmail(Order order, Customer customer)
        {
            Console.WriteLine($"Отправка email клиенту: {customer.Email}");

            string emailContent = $"Уважаемый {customer.Name}! " +
                                    $"Ваш заказ #{order.Id} " +
                                    $"на сумму {order.TotalAmount} создан.";

            Console.WriteLine($"Email отправлен: {emailContent}");
        }
    }
}