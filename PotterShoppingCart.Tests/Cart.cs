using PotterShoppingCart.Tests.Model;
using System;
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
            int sum = books.Sum(x => x.Quantity * x.Price);

            double discount = books.Select(x => x.SeriesNumber)
                                .Distinct()
                                .Count() == 2 ? 0.95 : 1;
            
            double totalPrice = sum * discount;

            var result = (int)Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);

            return result;
        }
    }
}