using Barcodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Barcode_Eve: EventArgs
    {
        public IBarcode Old_bar { get; init; }
        public IBarcode New_bar { get; init; }
        public Barcode_Eve(IBarcode old_bar, IBarcode new_bar) 
        { 
            Old_bar = old_bar;
            New_bar = new_bar;
        }
    }
}
