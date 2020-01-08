using Manual.Testers.Api.Host.Models;
using Manual.Testers.Api.Host.Models.OrderModels;
using System.Collections.Concurrent;
using System.Linq;

namespace Manual.Testers.Api.Host
{
    public class OrdersBasket
    {
        private static ConcurrentBag<OrderInStorage> _allOrders = new ConcurrentBag<OrderInStorage>();

        public static void AddOrderToStorage(Order order,int orderSum, string userId, int orderId)
        {
            _allOrders.Add(new OrderInStorage
            {
                Order = order,
                UserId = userId,
                OrderId = orderId,
                Sum = orderSum,
            });
        }

        public static Order GetOrderById(int orderId)
        {
            return _allOrders.Select(o => o.Order).FirstOrDefault();
        }
    }
}
