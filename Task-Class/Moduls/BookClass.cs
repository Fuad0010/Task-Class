using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class.Moduls
{
    internal class BookClass:Product
    {
        public string Genre;

        public BookClass(string genre,int no, string name, double price, int count):base(no,name,price,count)
        {
            Genre = genre;
        }

        public void GetInfo()
        {
            Console.WriteLine($"No: {No}\n" +
                              $"Name: {Name}\n" +
                              $"Price: {Price}\n" +
                              $"Count {Count}\n" +
                              $"-------------------");
        }
        public void GetPrice()
        {

        }
    
    
    }
}
