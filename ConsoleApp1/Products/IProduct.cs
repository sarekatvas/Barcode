using Barcodes;

namespace Product
{
    public interface IProduct
    {
        string Name { get; set; }
        string ProductId { get; }
        IBarcode Bar1 { get; set; }
        void UpdateBars();

        event EventHandler<Barcode_Eve> A;
    }
}
