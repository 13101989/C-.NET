using System;

namespace MyInvoice
{
    class InvoiceItem
    {
        public uint ProductId { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Series + Number
        /// </summary>
        public string Invoice { get; set; }
    }
}
