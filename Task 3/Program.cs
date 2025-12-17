using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

namespace Task_3
{
    internal class Program
    {
        public class Book
        {
           public string Title;
           public string Auther;
           public int ISBN;
           public bool Avalability;
           public bool IsBorrow = false;

            public Book(string title, string auther, int iSBN, bool avalability , bool isborrow)
            {
                this.Title = title;
                this.Auther = auther;
                this.ISBN = iSBN;
                this.Avalability = avalability;
                this.IsBorrow = isborrow;
            }
        }

        public class Library
        {

            public List<Book> books = new List<Book>();

            public void AddBook(Book book)
            {
                books.Add(book);
            }

            public Book SearchBook(string search)
            {
                foreach (var book in books)
                {
                    if(book.Title == search) 
                    { 
                        return book ;
                    }
                    if(book.Auther ==search)
                    {
                        return book;
                    }
                }
                return null;

            }

            public bool BorrowBook(string title)
            {
                foreach (var book in books)
                {
                    if (book.Title == title)
                    {
                        if (book.IsBorrow == false)
                        {
                            book.IsBorrow = true;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }   
                    return false;
             
            }

            public bool ReturnBook(string title)
            {
                foreach (var book in books)
                {
                    if (book.Title == title)
                    {
                        if (book.IsBorrow == true)
                        {
                            book.IsBorrow = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;

            }

        } 

            static void Main(string[] args)
            {
            Library library = new Library();
            Book b1 = new Book("ss", "sd" , 54 , true , true);
            library.AddBook(b1);

            bool borrowed = library.BorrowBook("n");
            Console.WriteLine(borrowed ? "is Borrowed":"Did Not Borrow");
            }

        }
    }

