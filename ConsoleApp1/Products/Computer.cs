using Barcodes;

namespace Product
{
    public sealed class Computer: Window
    {
        public int Material;
        public Computer (string productId, string name, string Creator, string date, int Batch, int material)
            : base(productId, name, Creator, date, Batch, new BarcodeRecord(productId.ToString()))
        {
            Material = material;
        }
        public override string ToString()
        {
            return base.ToString() + $" Creator: {Creator}\n Date: {Date}\n Batch: {Batch} \n Material: {Material}\n";
        }

        public new IBarcode Bar1
        {
            get =>base.Bar1;
            private set => base.Bar1 = value;
        }
    }
}
