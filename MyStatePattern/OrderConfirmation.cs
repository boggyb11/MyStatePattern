using System;
using System.Collections.Generic;
using System.Text;

namespace MyStatePattern
{
    class OrderConfirmation : OrderState
    {
        public override void OrderCheck(Basket basket)
        {
            basket.State = new Payment();
        }
    }
}
