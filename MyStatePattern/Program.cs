using System;

namespace MyStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket(new OrderConfirmation());

            basket.Request();

            basket.Request();

            Console.ReadKey();
        }
    }
}
