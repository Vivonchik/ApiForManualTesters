using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manual.Testers.Api.Host.Models.OrderModels
{
    public class OrderInStorage
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public Order Order { get; set; }

        public int Sum { get; set; }
    }
}
