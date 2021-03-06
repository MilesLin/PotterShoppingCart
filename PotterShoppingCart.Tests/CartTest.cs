﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void CheckTest_Buy_2_Book_With_Different_Chapter()
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
                },
                new Book()
                {
                    SeriesNumber = 1,
                    Name = "哈利波特第一集",
                    Quantity = 1,
                    Price = 100
                },
            };

            int expected = 190;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTest_Buy_3_Book_With_Different_Chapter()
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
                },
                new Book()
                {
                    SeriesNumber = 1,
                    Name = "哈利波特第一集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 2,
                    Name = "哈利波特第二集",
                    Quantity = 1,
                    Price = 100
                },
            };

            int expected = 270;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTest_Buy_4_Book_With_Different_Chapter()
        {
            //arrange
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    SeriesNumber = 1,
                    Name = "哈利波特第一集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 2,
                    Name = "哈利波特第二集",
                    Quantity = 1,
                    Price = 100
                },
                new Book()
                {
                    SeriesNumber = 3,
                    Name = "哈利波特第三集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 4,
                    Name = "哈利波特第四集",
                    Quantity = 1,
                    Price = 100
                },
            };

            int expected = 320;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTest_Buy_5_Book_With_Different_Chapter()
        {
            //arrange
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    SeriesNumber = 1,
                    Name = "哈利波特第一集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 2,
                    Name = "哈利波特第二集",
                    Quantity = 1,
                    Price = 100
                },
                new Book()
                {
                    SeriesNumber = 3,
                    Name = "哈利波特第三集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 4,
                    Name = "哈利波特第四集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 5,
                    Name = "哈利波特第五集",
                    Quantity = 1,
                    Price = 100
                },
            };

            int expected = 375;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTest_Buy_4_Book_With_3_Different_Chapter_1_Same_Chapter()
        {
            //arrange
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    SeriesNumber = 1,
                    Name = "哈利波特第一集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 2,
                    Name = "哈利波特第二集",
                    Quantity = 1,
                    Price = 100
                },
                new Book()
                {
                    SeriesNumber = 3,
                    Name = "哈利波特第三集",
                    Quantity = 2,
                    Price = 100
                }
            };

            int expected = 370;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTest_Buy_1_ChapterOne_2_ChapterTwo_2_ChapterThree()
        {
            //arrange
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    SeriesNumber = 1,
                    Name = "哈利波特第一集",
                    Quantity = 1,
                    Price = 100
                },new Book()
                {
                    SeriesNumber = 2,
                    Name = "哈利波特第二集",
                    Quantity = 2,
                    Price = 100
                },
                new Book()
                {
                    SeriesNumber = 3,
                    Name = "哈利波特第三集",
                    Quantity = 2,
                    Price = 100
                }
            };

            int expected = 460;

            var target = new Cart();

            //act
            int actual = target.Check(books);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}