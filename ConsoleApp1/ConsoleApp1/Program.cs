//using Product;
//using Barcodes;
//using Windows;

//internal class Program1
//{
//    private static void Main(string[] args)
//    {

//        var labData = new List<IProduct>
//        {
//        var computer = new Window("100011", "samsung", "factory", "23/12/2021", 12345);
//        var computer1 = new Window("1000", "hp", "factory1", "12/02/2023", 56789);
//        var computer2 = new Window("1000", "acer", "factory2", "06/07/2022", 835838);
//        var computer3 = new Window("1000", "vivo", "factory3", "19/02/2021", 2778534);
//        var computer4 = new Window("1000", "asus", "factory4", "09/07/2020", 1594975);
//        }
        
//        showcase.add(computer);
//        showcase.add(computer1);
//        showcase.add(computer2);
//        showcase.add(computer3);

//        Console.WriteLine("Список: \n");
//        Console.WriteLine(showcase.ToString());

//        Showcase<Computer> showCase = (5, 4);
//        var comp = new Computer("100145747", "samsung", "factory00", "23/12/2021", 123450, 1);
//        var comp1 = new Computer("1001", "hp", "factory01", "12/02/2023", 567890, 2);
//        var comp2 = new Computer("1001", "acer", "factory02", "06/07/2022", 8358380, 5);
//        var comp3 = new Computer("1001", "vivo", "factory03", "19/02/2021", 27785340, 5);
//        var comp4 = new Computer("1001", "asus", "factory04", "09/07/2020", 15949750, 5);
//        showCase.add(comp);
//        showCase.add(comp1);
//        showCase.add(comp2);
//        showCase.add(comp4);
//        Console.WriteLine("Список: \n");
//        Console.WriteLine(showCase.ToString());

//        showcase[4] = comp;
//        Console.WriteLine("Список: \n");
//        Console.WriteLine(showcase.ToString());
//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Поиск по порядковому номеру: \n");
//        //showcase.findByNumber(3);

//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Поиск по наименованию: \n");
//        //showcase.findByName("samsung");

//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Поиск по id: \n");
//        //showcase.findByID("10000101");

//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Удалить по id: \n");
//        //showcase.remove("10000101");
//        //Console.WriteLine(showcase.ToString());

//        Console.WriteLine("__________________________ \n");
//        Console.WriteLine("Замена: \n");
//        showcase.replace(2, computer4);
//        Console.WriteLine(showcase.ToString());

//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Перестановка: \n");
//        //showcase.exchange(1, 3);
//        //Console.WriteLine(showcase.ToString());

//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Сортировка по наименованию: \n");
//        //showcase.SortByName();
//        //Console.WriteLine(showcase.ToString());

//        //Console.WriteLine("__________________________ \n");
//        //Console.WriteLine("Сортировка по ID: \n");
//        //showcase.sortByID();
//        //Console.WriteLine(showcase.ToString());


//    }
//}