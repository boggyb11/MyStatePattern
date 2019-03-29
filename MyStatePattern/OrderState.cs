using System;
using System.Collections.Generic;
using System.Text;

namespace MyStatePattern
{
    abstract class OrderState
    {
        protected Basket basket;


        public Basket Basket
        {
            get{ return basket; }
            set { basket = value; }
        }

        public abstract void OrderCheck(Basket basket);
    }
}
