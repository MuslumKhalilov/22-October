//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp10
//{
//    internal class Library : Base
//    {
//        private static int _id = 1;
//        private List<Book> _books = new List<Book>();
//        public Library(string name)
//        {
//            Name = name;
//            Id = _id++;


//        }
//        public void AddBook(Book book)
//        {
//            _books.Add(book);

//        }
//        public void ListAllBooks()
//        {
//            foreach (var book in _books)
//            {
//                Console.WriteLine($"ID: {book.Id}, Name: {book.Name}, Author: {book.Author}, Category: {book.Category.Name}");
//            }

//        }

//    }
//}
