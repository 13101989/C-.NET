using System.Reflection.Metadata.Ecma335;

namespace Workshop
{
    public class Product
    {
        private int productId;
        private double amount;
        private string name;
        private int availableQuantity;

        public int ProductId { get; private set; }
        public double Amount { get; private set; }
        public string Name { get; private set; }
        public int AvailableQuantity { get; private set; }

        public Product GetProductDetails(int id)
        {
            Console.WriteLine("Fetching product in database");
            Product product = new Product()
            {
                ProductId = id,
                Name = "Phone",
                Amount = 1000,
                AvailableQuantity = 50
            };
            Console.WriteLine("ProductId = {0}, Name = {1}, Amount = {2}, AvailableQantity = {3}",
                product.ProductId, product.Name, product.Amount, product.AvailableQuantity);

            return product;
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public double OrderAmount { get; set; }
        public int ProductId { get; set; }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new Exception("Qunatity must be greater than zero");
                }
            }
        }

        public Order CreateOrder(Product product, int orderQuantity)
        {
            if (orderQuantity < 0)
            {
                throw new Exception("Qunatity must be greater than zero");
            }

            Order order = new Order()
            {
                OrderId = Guid.NewGuid().ToString(),
                OrderAmount = product.Amount * orderQuantity,
                ProductId = product.ProductId,
                Quantity = orderQuantity
            };
            Console.WriteLine("Order created in DB");
            Console.WriteLine("OrderId = {0}, OrderAmunt = {1}, ProductId = {2}, Quantity = {3}",
                order.OrderId, order.OrderAmount, order.ProductId, order.Quantity);

            return order;
        }
    }

    public class Payment
    {
        public bool MakePayment(double AmountToBePaid, string OrderId)
        {
            Console.WriteLine("Amount = {0} for order = {1}", AmountToBePaid, OrderId);
            return true;
        }
    }

    public class Invoice
    {
        public void SendInvoice(string orderId)
        {
            Console.WriteLine("Invoice send succesfully for order {0}", orderId);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create product
            Product product = new Product();
            var productResult = product.GetProductDetails(101);

            //Create order
            Order order = new Order();
            var orderResult = order.CreateOrder(productResult, 10);

            //Make the payment
            Payment payment = new Payment();
            var isPaymentSuccesful = payment.MakePayment(orderResult.OrderAmount, orderResult.OrderId);

            //Send invoice
            Invoice invoice = new Invoice();
            invoice.SendInvoice(orderResult.OrderId);

            Console.ReadKey();
        }
    }
}