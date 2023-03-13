using System;

namespace MyInvoice
{
    class Customer
    {
        public uint CustomerId;
        public string CustomerName { get; set; }
        public static uint CustomerIdcounter = 0;

        public Customer()
        {
            this.CustomerId = ++CustomerIdcounter;
        }
    }
}
