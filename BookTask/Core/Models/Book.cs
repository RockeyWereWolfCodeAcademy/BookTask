using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public uint PageCount { get; set; }
        public override void Sell()
        {
            if (Count == 0)
            {
                Console.WriteLine("Book is sold out");
                return;
            }
            Count--;
            if (Count == 0)
            {
               Library.Remove(Id);
            }
            TotalInCome++;
        }

        public static  void GetIncome()
        {
            Console.WriteLine(TotalInCome);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name of this book: {Name}, Price of this book: {Price}, Author: {AuthorName}, Page Count: {PageCount}, Count on stock: {Count}");
        }

        public Book(string name, uint price, string authorName, uint pageCount, uint stockCount)
        {
             Name = name;
             Price = price;
             AuthorName = authorName;
             PageCount = pageCount;
             Count = stockCount;
            _id++;
        }
    }
}
