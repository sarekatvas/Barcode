using Barcodes;
using Product;

namespace Windows
{
    public static class AnotherShowcase
    {
        /// <summary>
        /// Cтатический класс AnotherShowcase содержит метод расширения Update_Bars.
        /// Метод принимает два параметра: объект типа T и объект типа IShowcase<T>. 
        /// Данный метод расширения используется для обновления значения свойства Bar1 объекта типа T, который реализует интерфейс IProduct, 
        /// на основе информации, полученной из объекта типа IShowcase<T>.
        /// </summary>
        ///
        public static void UpdateBar<T>(this T comp,IShowcase<T> shcs) where T : class, IProduct
        {
            string i = shcs.FindName(comp.Name);
            comp.Bar1.Text = $"{comp.ProductId}{shcs.ID}{i}";
            
        }
    }
}
