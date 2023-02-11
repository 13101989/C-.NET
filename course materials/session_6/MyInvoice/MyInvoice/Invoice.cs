using System;
using System.Collections;
using System.Globalization;

namespace MyInvoice
{
    class Invoice
    {
        public string series { get; set; }
        private static int seed;
        private int number;
        public DateTime issued { get; set; }
        private decimal total;
        public const decimal VAT = 0.19M;
        public decimal totalFromItems;
        public decimal totalWithVAT;

        public Product[] products { get; set; }
        public Supplier[] suppliers { get; set; }
        public Customer[] customers { get; set; }
        public InvoiceItem[] InvoiceItems { get; set; }


        public string InvoiceNumber
        {
            get { return $"{series}{number}"; }
        }

        public decimal Total
        {
            get { return total; }
            set
            {
                foreach (var item in InvoiceItems)
                {
                    if (item != null)
                    {
                        var price = 0M;
                        foreach (var product in products)
                        {
                            if (product != null && item != null && product.ProductId == item.ProductId)
                            {
                                price = product.Price;
                                break;
                            }
                        }

                        this.totalFromItems += item.Quantity * price;
                    }
                }
                this.totalWithVAT = this.totalFromItems + this.totalFromItems * VAT;

                if (value != totalFromItems)
                {
                    Console.WriteLine($"WARNING! Invoice total {value} doesn't match total from items {totalFromItems}\n\n");
                }
                total = value;
            }
        }

        public uint InvoiceCustomerId { get; set; }
        public uint InvoiceSupplierId { get; set; }
        

        static Invoice()
        {
            seed = 100;
        }

        public Invoice(string series, string issued)
        {
            number = seed++;
            this.series = series;
            this.issued = DateTime.ParseExact(issued, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }


        public void DisplayInvoice()
        {
            Console.WriteLine($"Invoice: {this.series}");
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"Supplier: {suppliers[0].SupplierName}\nCustomer: {customers[0].CustomerName}\nIssued: {this.issued}");
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("No Product Price Quantity Value VAT");

            for (var i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    string StringQuantity = InvoiceItems[i].Quantity.ToString();
                    Console.WriteLine($"{products[i].ProductId + new string(' ', 2)}{products[i].ProductName.PadRight(8, ' ')}" +
                    $"{products[i].Price + new string(' ', 2)} " +
                    $"{StringQuantity.PadRight(9, ' ')}{products[i].Price * InvoiceItems[i].Quantity + new string(' ', 1)} " +
                    $"{products[i].Price * InvoiceItems[i].Quantity * VAT}");
                }
            }
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"TOTAL{new string(' ', 21) + totalFromItems}{new string(' ', 2) + totalFromItems * VAT}");
            Console.WriteLine($"TOTAL with VAT:{new string(' ', 16) + totalWithVAT}");
            Environment.Exit(0);
        }
    }
}
