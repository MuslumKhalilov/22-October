//namespace ConsoleApp10
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//Task 1
//SortedList<int, string> ProgrammingLanguages = new SortedList<int, string>();
//ProgrammingLanguages.Add(2000, "C#");
//ProgrammingLanguages.Add(1989, "Python");
//ProgrammingLanguages.Add(1995, "JavaScript");
//ProgrammingLanguages.Add(1983, "C++");
//foreach (var item in ProgrammingLanguages)
//{
//    Console.WriteLine($"Programming Language Name: {item.Value}   |   Year created: {item.Key}");
//}














//Task 2
//            List<Category> categories = new List<Category>
//        {
//            new Category("Klassik"),
//            new Category("Komediya"),

//        };

//            List<Book> books = new List<Book>
//        {
//            new Book("Robinzon Kruzo", "Muellif", categories[0]),
//            new Book("Mauqli", "Muellif", categories[1]),

//        };

//            List<Library> libraries = new List<Library>
//        {
//            new Library("Library 1"),
//            new Library("Library 2"),
//        };

//            libraries[0].AddBook(books[0]);

//            libraries[1].AddBook(books[1]);


//            bool exitprogram = false;

//            while (!exitprogram)
//            {

//                int option;
//                Console.WriteLine("-----------\r\n Ana Menyu \r\n-----------\r\n [1] Yeni kitabxana yarat \r\n [2] Yeni kateqoriya yarat \r\n [3] Yeni kitab yarat \r\n [4] Kitabxanaya daxil ol \r\n [5] Proqramdan chix ");
//                option = int.Parse(Console.ReadLine());

//                switch (option)
//                {
//                    case 1:
//                        Console.WriteLine("----------------------\r\n Yeni kitabxana yarat\r\n----------------------");
//                        string libraryname = Console.ReadLine();
//                        Library library1 = new Library(libraryname);
//                        libraries.Add(library1);
//                        Console.WriteLine($"{libraryname} adli kitabxana yaradildi");
//                        break;

//                    case 2:
//                        Console.WriteLine("-----------------------\r\n Yeni kateqoriya yarat\r\n-----------------------");
//                        string categoryname = Console.ReadLine();
//                        Category category = new Category(categoryname);
//                        categories.Add(category);
//                        Console.WriteLine($"{categoryname} adli kateqoriya yaradildi");
//                        break;

//                    case 3:
//                        Console.WriteLine("------------------\r\n Yeni kitab yarat\r\n------------------");
//                        Console.WriteLine("Kitabin adini daxil et");
//                        string bookname = Console.ReadLine();
//                        Console.WriteLine("Yazari kimdir?");
//                        string authorname = Console.ReadLine();
//                        Console.WriteLine("Kateqoriya sec");
//                        foreach (Category category1 in categories)
//                        {
//                            Console.WriteLine($"Id: {category1.Id}   |   Name: {category1.Name}");
//                        }
//                        Console.WriteLine("Id daxil edin");
//                        int categoryid = int.Parse(Console.ReadLine()) - 1;
//                        if (categoryid < 0 || categoryid >= categories.Count)
//                        {
//                            Console.WriteLine("Bele bir kateqoriya yoxdur");
//                            return;
//                        }
//                        Book book = new Book(bookname, authorname, categories[categoryid]);
//                        Console.WriteLine($"{bookname} adli kitab yaradildi");
//                        books.Add(book);

//                        break;

//                    case 4:
//                        Console.WriteLine("Kitabxana sech:");
//                        foreach (Library library in libraries)
//                        {
//                            Console.WriteLine($"Id: {library.Id}   |   Name: {library.Name}");
//                        }
//                        int libraryindex = int.Parse(Console.ReadLine()) - 1;
//                        if (libraryindex < 0 || libraryindex >= libraries.Count)
//                        {
//                            Console.WriteLine("Bele bir kitabxana yoxdur");
//                            return;
//                        }
//                        //Library selectedlibrary = libraries[libraryindex];

//                        bool exitLibraryMenu = false;

//                        while (!exitLibraryMenu)
//                        {
//                            Library selectedlibrary = libraries[libraryindex];

//                            Console.WriteLine("-------------------\r\n Kitabxana Menyusu \r\n-------------------\r\n [1] Kitab elave et \r\n [2] kitablari goster \r\n [3] Kitabxanadan chix");
//                            int option1 = int.Parse(Console.ReadLine());
//                            switch (option1)
//                            {
//                                case 1:
//                                    foreach (Book book1 in books)
//                                    {
//                                        Console.WriteLine($"Id: {book1.Id}   |   Name: {book1.Name}   |   Author: {book1.Author}   |   Category: {book1.Category.Name}");
//                                    }
//                                    Console.WriteLine("Id daxil edin:");
//                                    int bookindex = int.Parse(Console.ReadLine()) - 1;
//                                    if (bookindex < 0 || bookindex >= books.Count)
//                                    {
//                                        Console.WriteLine("Bele bir kitab yoxdur");
//                                        return;
//                                    }
//                                    Book selectedbook = books[bookindex];
//                                    selectedlibrary.AddBook(selectedbook);
//                                    break;

//                                case 2:
//                                    selectedlibrary.ListAllBooks();

//                                    break;

//                                case 3:
//                                    exitLibraryMenu = true;


//                                    break;






//                            }
//                        }

//                        break;
//                    case 5:
//                        exitprogram = true;
//                        break;


//                }





//            }
//        }
//    }

//}