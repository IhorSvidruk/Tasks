using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1

    public class MyProgram
    {
        public static void SearchKeys(Dictionary<string, string> persons)
        {
            foreach (var Keys in persons.Keys)
            {
                Console.WriteLine(Keys);
            }
        }

        public static void SearchValues(Dictionary<string, string> persons)
        {
            foreach (var Values in persons.Values)
            {
                Console.WriteLine(Values);
            }
        }

        public static void SearchAdmin(Dictionary<string, string> person)
        {
            foreach (var Admin in person)
            {
                if (Admin.Value == "Admin") Console.WriteLine(Admin.Key + " " + Admin.Value);
            }
        }
    }

    //Task 2

  

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            foreach (var Total in lookup)
            {
                decimal totalPrice = 0;
                foreach (var item in Total)
                {
                    Console.WriteLine(item.Name + " " + item.Price);
                    totalPrice += item.Price;
                }

                Console.WriteLine(Total.Key + " " + totalPrice);

            }
        }
    }

    //Task 3

  
   
    class MyProgram1
    {
        public static void Position(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.ElementAt(i) == 5)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }

        public static void Remove(List<int> List)
        {
            List.RemoveAll(num => num > 20);
            foreach (var num in List)
            {
                Console.WriteLine(num);
            }
        }

        public static void Insert(List<int> numbers)
        {
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Sort(List<int> numbers)
        {
            numbers.Sort();
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
