using PotterShoppingCart.Tests.Model;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.Tests
{
    /// <summary>
    /// 購物車
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// 結帳
        /// </summary>
        /// <param name="books">購買書本資訊</param>
        /// <returns>結帳金額</returns>
        public int Check(IEnumerable<Book> books)
        {
            return books.Sum(x => x.Quantity * x.Price);
        }
    }
}