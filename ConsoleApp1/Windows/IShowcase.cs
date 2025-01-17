using Product;

namespace Windows
{
    public interface IShowcase<T>
        where T : class, IProduct
    {   // //Т ссылочный тип, который реализует интерфейс IProduct. Если у предметов в контейнерах разные первый родитель, то смешение невозможно
        T this[int index] { get; set; }
        int ID { get; set; }
        void FindByNumber(int number);
        string Find<TD>(string x, Func<T, TD> y);
        string FindName(string f);
        //string FindID(string f);
        void Remove(string id);
        void Exchange(int i, int x);
        void SortByID();
        void SortByName();
        void Update(int i);
        void UpdateAll();

    }
}
