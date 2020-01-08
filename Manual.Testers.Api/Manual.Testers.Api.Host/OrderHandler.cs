using Manual.Testers.Api.Host.Models;
using System;
using System.Linq;

namespace Manual.Testers.Api.Host
{
    public class OrderHandler
    {

        public int HandleNewOrder(Order order, string userId)
        {
            var orderId = new Random().Next();
            OrdersBasket.AddOrderToStorage(order, CalculateOrderSum(order), userId, orderId);
            return orderId;
        }

        private int CalculateOrderSum(Order order)
        {
            return order.Goods.Sum(o => o.Price);
        }
    }
}
