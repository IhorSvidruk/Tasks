using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1
    delegate double CalcDelegate(double num1, double num2, char operation);

    class CalcProgram
    {
        public static double Calc(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num2 != 0 ? num1 / num2 : 0;
                default:
                    throw new ArgumentException("IsFracZeroCorrect");
            }

        }

        public CalcDelegate funcCalc = new CalcDelegate(Calc);
    }

    //Task 2

    static class StringExtensions
    {
        public static int WordCount(this string input)
        {

            char[] delimiters = { ' ', '.', '?', '!', '-', ';', ':', ',' };


            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


            return words.Length;
        }
    }

    //Task 3

   
    class ListProgram
    {
        public static List<int> ListWithPositive(List<int> inputList)
        {
            List<int> filteredList = inputList.FindAll(delegate (int num)
            {
                return num > 0 && num <= 10;
            });

            return filteredList;
        }


    }

    //Task 4

  
    internal static class IListExtensions
    {
        public static void IncreaseWith(this IList<int> list, int increment)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += increment;
            }
        }
    }
    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> collection)
        {
            string result = "[" + string.Join(", ", collection) + "]";
            return result;
        }
    }

    //Task 5

    class EventProgram
    {
        delegate void EventHandler();
        private event EventHandler Show;

        public EventProgram()
        {
            Show += Dog;
            Show += Cat;
            Show += Mouse;
            Show += Elephant;
            Show?.Invoke();
        }



        public static void Cat()
        {
            Console.WriteLine("Cat");
        }

        public static void Dog()
        {
            Console.WriteLine("Dog");
        }

        public static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
        public static void Elephant()
        {
            Console.WriteLine("Elephant");
        }

    }
}
