using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Tests.Model;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void CheckTest_Buy_1_Book()
        {
            //arrange
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    SeriesNumber = 3,
                    Name = "哈利波特第三集",
                    Quantity = 1,
                    Price = 100
                }
            };

            int expected = 100;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}