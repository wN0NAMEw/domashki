using System;

namespace chetonovoe
{
    public class disco
    {
        public double ApplyDiscountIfNeeded(Order order, bool isDiscountApplied)
        {
            double totalAmount = order.CalculateTotalAmount();

            if (isDiscountApplied)
            {
                Console.WriteLine("Применение скидки 10%");
                totalAmount *= 0.9;
            }

            order.TotalAmount = totalAmount;
            Console.WriteLine($"Итоговая сумма: {totalAmount}");

            return totalAmount;
        }
    }
}