using System.Collections.Generic;

namespace Manual.Testers.Api.Host.Models
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Дата заказа.
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// Список товаров с ценами.
        /// </summary>
        public List<Good> Goods { get; set; }
    }
}
