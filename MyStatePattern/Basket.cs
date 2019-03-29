using System;
using System.Collections.Generic;
using System.Text;

namespace MyStatePattern
{
    //Context Class
    class Basket
    {
        private OrderState _state;

        public Basket(OrderState state)
        {
            State = state;
        }

        public OrderState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Request()
        {
            _state.OrderCheck(this);
        }
    }
}
