namespace PotterShoppingCart.Tests.Model
{
    /// <summary>
    /// 書本資訊
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 書本序列號
        /// </summary>
        public int SeriesNumber { get; set; }

        /// <summary>
        /// 書本名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 購買數量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 書本販售價錢
        /// </summary>
        public int Price { get; set; }
    }
}