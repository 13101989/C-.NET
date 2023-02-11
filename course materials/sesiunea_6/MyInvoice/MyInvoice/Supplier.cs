using System;

namespace MyInvoice
{
    class Supplier
    {
        public uint SupplierId;
        public string SupplierName { get; set; }
        public static uint SupplierIdIdcounter = 0;

        public Supplier()
        {
            this.SupplierId = ++SupplierIdIdcounter;
        }

    }
}
