namespace Barcodes
{
    public record class BarcodeRecord : IBarcode
    {
        private string text;
        private string title;
        public string Text
        {
            get { return text; }    
            set
            {
                if (text == value) return;
                text = value;
                BarcodeText = BarcodeParametrs.TextToCode(text);
                title = BarcodeParametrs.CodeToBar(BarcodeText);
            }
        }
        public string BarcodeText { get; private set; }
        /// <summary>
        /// BT - способ вывода штрихкода
        /// </summary>
        public static BarcodeType BT { get; set; } = BarcodeType.Full;

        public BarcodeRecord(string text)
        {
            Text = text;

        }
        public override string ToString()
        {
            if (BT == BarcodeType.Text)
                return "* " + text + "*";
            else if (BT == BarcodeType.Barcode)
                return title;
            else return title + "\n" + "* " + text + "*"; 
        }
    }
}
