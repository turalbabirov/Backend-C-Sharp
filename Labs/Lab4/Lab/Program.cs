using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1 - Lab4;
            //Book class:
            //No
            //Name
            //AuthorName
            //PageCount

            //Hər kitab əlavə olunduqda kitabın No(nömrəsi artsın)
            Book book1 = new Book("Sefiller1", "Semed1", 2871);
            Console.WriteLine(book1.ShowAll());
                
            Book book2 = new Book("Sefiller2", "Semed2", 2872);
            Console.WriteLine(book2.ShowAll());

            Book book3 = new Book("Sefiller3", "Semed3", 2873);
            Console.WriteLine(book3.ShowAll());

            Book book4 = new Book("Sefiller4", "Semed4", 2874);
            Console.WriteLine(book4.ShowAll());



            Console.WriteLine("------");
            Console.WriteLine("");

            #endregion

            #region Task2 - Lab4;
            //Library class:
            //list sekilinde book saxlayiriq: public List<Book> books = new List<Book>();

            //AddBook() - Book tipinde deyer qebul edir

            //FindAllBooksByName() - parametr olaraq string value qebul edir
            //ve adinda hemin string value olan booklardan ibaret list qaytarsin

            //RemoveAllBookByName() - parametr olaraq string vaue gonderilir
            //ve adinda hemin string value olan booklari silir

            //SearchBooks() - parametr olaraq string qebul edir
            //ve Name, AuthorName, PageCount deyerlerinden her hansi birinde gonderilmis
            //string valuesi olan booklardan ibaret list qaytarir



            //AddBook() -----------------
            Library library = new Library();
            library.AddBook(new Book("Test1", "Author1", 100));
            library.AddBook(new Book("Test2", "Author2", 200));
            library.AddBook(new Book("Test3", "Author3", 300));
            library.AddBook(new Book("Test3", "Author3", 300));
            library.AddBook(new Book("Test4", "Author4", 400));
            library.AddBook(new Book("Final", "Author5", 500));
            library.AddBook(new Book("Test2", "Author2", 200));
            library.AddBook(new Book("Test1", "Author1", 100));

            Console.WriteLine("AddBook()");
            Console.WriteLine("-------------------->>>>");
            foreach (Book item in library.books)
            {
                Console.WriteLine($"No: {item.No} \nName: {item.Name} \n");
            }
            Console.WriteLine("");



            //FindAllBooksByName() -----------------
            List<Book> listbook1 = library.FindAllBooksByName("Test3");

            Console.WriteLine("FindAllBooksByName()");
            Console.WriteLine("-------------------->>>>");
            foreach (Book item in listbook1)
            {
                Console.WriteLine($"No: {item.No} \nName: {item.Name} \n");
            }
            Console.WriteLine("");



            //RemoveAllBookByName() -----------------
            library.RemoveAllBookByName("Test2");

            Console.WriteLine("RemoveAllBookByName()");
            Console.WriteLine("-------------------->>>>");
            foreach (Book item in library.books)
            {
                Console.WriteLine($"No: {item.No} \nName: {item.Name} \n");
            }
            Console.WriteLine("");



            //SearchBooks() -----------------
            List<Book> listbook2 = library.SearchBooks("Test1");

            Console.WriteLine("SearchBooks()");
            Console.WriteLine("-------------------->>>>");
            foreach (Book item in listbook2)
            {
                Console.WriteLine($"No: {item.No} \nName: {item.Name} \n");
            }
            Console.WriteLine("");


            #endregion
        }

        //Task1:
        class Book
        {
            public Book(string name, string author, int count)
            {
                Name = name;
                AuthorName = author;
                PageCount = count;
                No = ++_no;
                ShowAll();
            }
            private static int _no = 0;
            public int No;
            public string Name;
            public string AuthorName;
            public int PageCount;
            public string ShowAll()
            {
                return $"No: {No}, Name: {Name}, AuthorName: {AuthorName}, PageCount: {PageCount}";
            }
        }

        //Task2:
        class Library
        {
            public List<Book> books = new List<Book>();

            public void AddBook(Book deyer)
            {
                books.Add(deyer);
            }

            public List<Book> FindAllBooksByName(string value)
            {
                return books.FindAll(item => item.Name == value);
            }

            public void RemoveAllBookByName(string value)
            {
                books.RemoveAll(item =>
                {
                    return item.Name == value;
                });
            }

            public List<Book> SearchBooks(string value)
            {
                return books.FindAll(item => item.Name == value);
            }
        }
    }
}
