using Barcodes;

namespace Product
{
    public abstract class Hardware : IProduct
    {
        private string productId;
        private string _idd = "124435";
        private IBarcode Bar;
        public string Name { get; set; }
        public IBarcode Bar1 
        { 
            get => Bar; 
            set
            {
                Bar = value;
            }
        }
        /// <summary>
        /// Объявляет событие A, которое является экземпляром делегата EventHandler<Barcode_Eve>. 
        /// EventHandler<TEventArgs> - это обобщенный делегат, который представляет метод, обрабатывающий событие. 
        /// Он принимает два параметра: отправителя события (тип object) и объект типа TEventArgs, который содержит данные о событии.
        /// При возникновении события A, будет вызываться метод или набор методов, которые были добавлены в список обработчиков этого события.
        /// </summary>
        public event EventHandler<Barcode_Eve> A;


        public Hardware(string productId, string name, IBarcode bar1)
        {
            ProductId = productId;
            Name = name;
            Bar1 = bar1;
        }   
        public string ProductId
            {
                get => productId;
                set
                {
                if (productId == value) return;
                productId = value;
                IBarcode _Bar1 = new Barcode1(_idd);
                UpdateBars();
                A?.Invoke(this, new(Bar,_Bar1));
            }
            }

        public void UpdateBars()
        {
            Bar1 = new BarcodeRecord(ProductId);
        }
        public override string ToString()
        {
            return $" Barcode:\n{Bar1}\n Name: {Name}\n prod: {ProductId}\n";
        }
    }
}
