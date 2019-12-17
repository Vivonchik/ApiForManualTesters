using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manual.Testers.Api.Host.Models
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Good
    {
        /// <summary>
        /// Имя товара.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        public int Price { get; set; }
    }
}
