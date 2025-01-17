using Product;
using System.Security.Cryptography.X509Certificates;

namespace Windows
{
    public class Showcase<T> : IShowcase<T> where T : class, IProduct
    {
        /// <summary>
        /// Объявляет событие IdChange, которое является экземпляром делегата Action<Showcase<T>>. 
        /// Action<T> - это обобщенный делегат, который представляет метод, не принимающий параметров и не возвращающий значение.
        /// Данное событие используется для уведомления об изменении идентификатора объекта типа Showcase<T>.
        /// </summary>
        private Action<IShowcase<T>> IdChange;

        private int id;
        public int length;
        private T[] products;
        public int ID {
            set
            {
                if (id == value) return;
                id = value;
                IdChange?.Invoke(this);
            }
            get { return id; }
        }

        public static implicit operator Showcase<T>((int count, int id) v)
        {
            return new Showcase<T>(v.count, v.id);
        }
        private Showcase(int count, int id)
        {
            products = new T[count];
            ID = id;
        }
        public T this[int index]
        {
            get
            {
                T tmp = products[index];
                products[index] = null;
                if (tmp != null) tmp.A -= Changed_Showcase;
                if (tmp != null) IdChange -= tmp.UpdateBar;
                return tmp;
            }
                
            set
            {
                if (products[index] == null)
                {
                    products[index] = value;
                    if (value != null) IdChange += value.UpdateBar;
                    if (value != null) value.A += Changed_Showcase;
                    value.UpdateBar(this);
                    //AnotherShowcase.UpdateBar(value, this);
                }
                else Console.WriteLine("Данное место на складе занято!");
            }
        }

        public void add(T product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    this[i] = product;
                    return;
                }

            }
        }
        public void FindByNumber(int number)
        {
            string finalityStr = "";
            for (int i = 0; i <= number; i++)
            {
                if (products[i] != null) {
                    T tmp = products[i];
                    if (products[i] == products[number])
                    {
                        finalityStr = $"{number}. {products[number].ToString()}\n\n\n";
                    }
                }
                else finalityStr = $"{i}. Свободное место\n\n\n";
            }
            Console.WriteLine(finalityStr);
        }
        
        //public string FindByName(string name)
        //{
        //    string finalityStr = "";
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (products[i] != null)
        //        {
        //            T tmp = products[i];
        //            if (products[i].Name == name)
        //            {
        //                finalityStr = $"{i}. {products[i].ToString()}\n\n\n";
        //                break;
        //            }
        //            else finalityStr = $"{i}. Свободное место\n\n\n";
        //        }
        //    }
        //    return finalityStr;
        //}

        //public void FindByID(string id)
        //{
        //    string finalityStr = "";
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (products[i] != null)
        //        {
        //            T tmp = products[i];
        //            if (products[i].ProductId == id)
        //            {
        //                finalityStr = $"{i}. {products[i].ToString()}\n\n\n";
        //                break;
        //            }
        //            else finalityStr = $"{i}. Свободное место\n\n\n";
        //        }
        //    }
        //    Console.WriteLine(finalityStr);
        //}

        public string Find<TD>(string x, Func<T,TD> y)
        {
            string finalityStr = "";
            for (int i = 0; i < products.Length; i++)
            {
                if (x.CompareTo(y(products[i])) == 0)
                {
                    finalityStr = $"{i}. {products[i].ToString()}\n\n\n";
                    break;
                }
            }
            return finalityStr;
        }
        public string FindName(string f)
        {
            return Find(f, (comp) => comp.Name);
        }
        public string FindID(string f)
        {
            return Find(f, (comp) => comp.ProductId);
        }

        public void Remove(string id)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null) continue;
                if (products[i].ProductId == id) products[i] = null;
            }
        }

        public void replace(int number, T product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[number] = product;
                Update(number);
            }
        }

        public void Exchange(int i, int x)
        {
            T tmp = products[i];
            products[i] = products[x];
            products[x] = tmp;
        }

        public void SortByID()
        {
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = i + 1; j < products.Length; j++)
                {
                    if (products[i] != null && products[j] != null)
                    {
                        if (string.Compare(products[i].ProductId, products[j].ProductId) > 0)
                        {
                            T tmp = (T)products[i];
                            products[i] = products[j];
                            products[j] = tmp;
                        }
                    }
                }
            }
        }

        public void SortByName()
        {
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = i + 1; j < products.Length; j++)
                {
                    if (products[i] != null && products[j] != null)
                    {
                        if (string.Compare(products[i].Name, products[j].Name) > 0)
                        {
                            T temp = products[i];
                            products[i] = products[j];
                            products[j] = temp;
                        }
                    }
                }
            }
        }

        public void Update(int i)
        {
            products[i].Bar1.Text = $"{products[i].ProductId} {ID} {i}";
        }

        public void UpdateAll()
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is null) continue;
                else if (products[i] is Computer) continue;
                Update(i);
            }
        }

        public override string ToString()
        {
            string finalityStr = "";
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    finalityStr += $"{i}. {products[i].ToString()}\n\n\n";
                }
                else finalityStr += $"{i}. Свободное место\n\n\n";
            }
            return finalityStr;
        }
        
        private void Changed_Showcase(object? sender, Product.Barcode_Eve e)
        {
            if (sender is T good) good.UpdateBars();
        }
    }
}
