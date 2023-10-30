using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Library
    {
        static Book[] _books = new Book[0];
        public static void AddBook(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        internal static void Remove(uint id)
        {
            int index;
            for (index = 0; index < _books.Length; index++)
            {
                if (_books[index].Id == id)
                {
                    break;
                } else
                {
                    Console.WriteLine("Book not found");
                    return;
                }
            }
            Book[] newArray = new Book[_books.Length - 1];
            Array.Copy(_books, 0, newArray, 0, index);
            Array.Copy(_books, index + 1, newArray, index, _books.Length - index - 1);
            _books = newArray;
            //if (index >= 0 && index < _array.Length)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Invalid index. Vehicle not removed.");
            //}
        }



        public static Book GetBookById(int id)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Id == id)
                {
                    return _books[i];
                }
            }
            Console.WriteLine("Book not found");
            return _books[0];
        }

        public static void ShowAllBooks()
        {
            for (int i =0; i < _books.Length;i++)
            {
                Console.Write(_books[i].Id + ". ");
                _books[i].ShowInfo();
            }
        }
    }
}
