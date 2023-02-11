using System;
using static System.Net.Mime.MediaTypeNames;


namespace MyInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            // populate products list
            Product[] products = new Product[MAX];

            products[0] = new Product { ProductName = "Apple", Price = 5.5M, Type = ProductType.Food };
            products[1] = new Product { ProductName = "Nail", Price = 0.2M, Type = ProductType.NonFood };
            //products[2] = new Product {Name = "Antivirus", Price = 100M, Type = ProductType.Services };
            //Console.WriteLine($"product_1_id: {products[0].Id}, product_2_id: {products[1].Id}, product_3_id: {products[2].Id}");
            
            // populate customers list
            Customer[] customers = new Customer[MAX];
            customers[0] = new Customer { CustomerName = "Camara Noastra" };
            //customers[1] = new Customer { Name = "iStyle" };
            //Console.WriteLine($"customer_1_id: {customers[0].Id}, customer_2_id: {customers[1].Id}");

            // populate suppliers list
            Supplier[] suppliers = new Supplier[MAX];
            suppliers[0] = new Supplier { SupplierName = "Lidl" };
            //suppliers[1] = new Supplier { Name = "Carrefour" };
            //Console.WriteLine($"supplier_1_id: {suppliers[0].Id}, supplier_2_id: {suppliers[1].Id}");

            // create invoice
            var invoice = new Invoice("A101", "24/01/2022");
            invoice.customers = customers;
            invoice.suppliers = suppliers;
            invoice.products = products;
            invoice.InvoiceCustomerId = customers[0].CustomerId;
            invoice.InvoiceSupplierId = suppliers[0].SupplierId;

            // populate invoice items
            InvoiceItem[] InvoiceItems = new InvoiceItem[MAX];
            InvoiceItems[0] = new InvoiceItem { ProductId = products[0].ProductId, Quantity = 4, Invoice = invoice.InvoiceNumber };
            InvoiceItems[1] = new InvoiceItem { ProductId = products[1].ProductId, Quantity = 50, Invoice = invoice.InvoiceNumber };
            //invoiceItems[2] = new InvoiceItem { ProductId = products[2].Id, Quantity = 1, Invoice = invoice.InvoiceNumber };
            invoice.InvoiceItems = InvoiceItems;
            invoice.Total = 175;

            invoice.DisplayInvoice();

            Console.ReadKey();
        }
    }
}
