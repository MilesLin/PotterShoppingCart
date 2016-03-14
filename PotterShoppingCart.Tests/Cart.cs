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
        public int Check(List<Book> books)
        {
            int maxQuantity = books.Max(x => x.Quantity);

            int result = 0;

            for (int i = 0; i < maxQuantity; i++)
            {
                int sum = books.Where(x => x.Quantity > 0).Sum(x => x.Price);

                double discount = this.GetDiscount(books);

                double totalPrice = sum * discount;

                result += (int)Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);

                books.ForEach(x => x.Quantity -= 1);
            }

            return result;
        }

        /// <summary>
        /// 取得折扣
        /// </summary>
        /// <param name="books">書本資訊</param>
        /// <returns>折扣</returns>
        private double GetDiscount(IEnumerable<Book> books)
        {
            int differentSeriesQuantity = books.Where(x => x.Quantity > 0)
                                               .Select(x => x.SeriesNumber)
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

                case 4:
                    discount = 0.8;
                    break;

                case 5:
                    discount = 0.75;
                    break;
            }

            return discount;
        }
    }
}