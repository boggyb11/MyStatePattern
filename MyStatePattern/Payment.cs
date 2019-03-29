using System;
using System.Collections.Generic;
using System.Text;

namespace MyStatePattern
{
    class Payment : OrderState
    {
        public override void OrderCheck(Basket basket)
        {
            Console.WriteLine("Completed Payment");
        }
    }
}
