using System;

namespace MyInvoice
{
    class Product
    {
        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public static uint ProductIdcounter = 0;

        public Product()
        {
            this.ProductId = ++ProductIdcounter;
        }
    }
}
