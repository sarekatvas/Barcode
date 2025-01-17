using Barcodes;

namespace Product
{
    public class Window:Hardware
    {
        /// <summary>
        ///     производитель
        /// </summary>
        public string Creator { set; get; }
        /// <summary>
        ///     номер партии
        /// </summary>
        public int Batch { set; get; }
        /// <summary>
        ///     дата сборки
        /// </summary>
        public string Date { get; set; }
        public Window(string productId, string name, string creator, string date, int batch, IBarcode bar1 = null) 
            : base (productId, name,bar1 ?? new Barcode1(productId.ToString()))
        {
            Date = date;
            Creator = creator;
            Batch = batch;
        }
        public override string ToString()
        {
            return base.ToString() + $" Creator: {Creator}\n date: {Date}\n Batch: {Batch} \n";
        }

    }
}
