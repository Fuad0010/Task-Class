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

                string genre = GetInputWord($"Please enter the genre: ",1, 15);

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

            do
            {
               
               int key = GetInputInt("-----------------------------------\n" +
                                      "1. Kitablari qiymete gore filterle\n" +
                                      "2. Butun kitablari goster\n" +
                                      "0. Proqrami bagla\n", 0, 2);


                if (key == 2)
                {
                    foreach (var item in books)
                    {
                        item.GetInfo();
                        Console.WriteLine("-------------------------------");
                    }
                }
                else if (key == 1)
                {
                    Console.WriteLine("Please enter max value for ");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter min value for ");
                    int max = Convert.ToInt32(Console.ReadLine());

                    

                    foreach (var item in books)
                    {
                        //if (min > )
                            item.GetInfo();
                        Console.WriteLine("--------------------------");
                    }
                }
                else if (key == 0)
                return;
                    
            } while(true); 




            //switch (key)
            //    {
            //    case 0:
            //        return;
            //    case 1:

            //        break;                

            //}



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
