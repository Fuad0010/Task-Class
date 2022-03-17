using System;
using Task_Class.Moduls;

namespace Task_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = GetInputInt ("Please enter the count: ",0,5);

            BookClass[] books = new BookClass[count1];
            for (int i = 0; i < count1; i++)
            {
                Console.WriteLine("-----------------------------------");

                int no = GetInputInt($"Please enter the book number: ", 0, 200);

                string name = GetInputWord($"Please enter the name: ", 2, 10);

                double price = GetInputInt($"Please enter the price: ", 1, 1000);

                int count = GetInputInt($"Please enter the count: ", 0, 100);

                string genre = GetInputWord($"Please enter the genre: ",1, 10);

                books[i] = new BookClass(genre,no,name, price, count)
                {
                    Name = name,
                    Price = price,
                    Count = count
                };

            }

            Console.WriteLine("===============================");
            Console.WriteLine("List of Books");

            foreach (var item in books)
            {
                item.GetInfo();
                Console.WriteLine("-------------------------------");
            }

            int key = GetInputInt ("1. Kitablari qiymete gore filterle\n" +
                                   "2. Butun kitablari goster\n" +
                                   "0. Proqrami bagla\n",0,2);

            switch (key)
                {
                case 0:
                    return;
                
                

            }



        }




        static int GetInputInt(string name, int minValue, int maxValue)
        {


            int input;

            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());

            } while (input < minValue || input > maxValue);
            return input;
        }

        static string GetInputWord(string name, int minValue, int maxValue)
        {


            string input;

            do
            {
                Console.Write(name);
                input = Console.ReadLine();

            } while (input.Length < minValue || input.Length > maxValue);
            return input;
        }
    }

}
