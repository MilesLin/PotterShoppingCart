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

            double discount = this.GetDiscount(books);            

            double totalPrice = sum * discount;

            var result = (int)Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);

            return result;
        }

        /// <summary>
        /// 取得折扣
        /// </summary>
        /// <param name="books">書本資訊</param>
        /// <returns>折扣</returns>
        private double GetDiscount(IEnumerable<Book> books)
        {
            int differentSeriesQuantity = books.Select(x => x.SeriesNumber)
                                               .Distinct()
                                               .Count();

            double discount = 1;
            switch (differentSeriesQuantity)
            {                
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;                
            }

            return discount;
        }

        
    }
}