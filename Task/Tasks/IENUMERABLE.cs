using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1
    public class CircleOfChildren
    {
        private IEnumerable<string> children;

        public CircleOfChildren(IEnumerable<string> children)
        {
            this.children = children;
        }

        public IEnumerable GetChildrenInOrder(int syllablesCount, int maxChildrenCount = 0)
        {
            if (syllablesCount <= 0)
                yield break;
            List<string> circle = new List<string>(children);
            if (maxChildrenCount <= 0 || maxChildrenCount > circle.Count)
                maxChildrenCount = circle.Count;
            for (int i = 0, index = syllablesCount - 1; i < maxChildrenCount; i++, index += syllablesCount - 1)
            {
                index = index % circle.Count;
                yield return circle[index];
                circle.RemoveAt(index);
            }
        }

    }

    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren circle, int syllablesCount, int maxChildrenCount = 0)
        {
            foreach (string child in circle.GetChildrenInOrder(syllablesCount, maxChildrenCount))
            {
                Console.Write(child + " ");
            }
        }
    }

    //Task 2

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }
    }

    public class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public IEnumerable<Book> Books
        {
            get { return books; }
        }

        public static Predicate<Book> Filter { get; set; } = book => true;

        public Library(IEnumerable<Book> initialBooks)
        {
            books = new List<Book>(initialBooks);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new MyEnumerator(Books, Filter);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public sealed class MyEnumerator : IEnumerator<Book>
    {
        private int position = -1;
        private readonly List<Book> books;
        private readonly Predicate<Book> filter;

        public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
        {
            this.books = new List<Book>(books);
            this.filter = filter;
        }

        public Book Current => books[position];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            while (++position < books.Count && !filter(books[position])) ;
            return position < books.Count;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    public static class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book> filterCondition)
        {
            Library.Filter = filterCondition;
            List<Book> result = new List<Book>();
            foreach (Book book in new Library(books))
            {
                result.Add(book);
            }

            return result;
        }
    }

    //Task 3

    class ShowPower
    {
        public static IEnumerable<float> SuperPower(int number, int deg)
        {
            float result = 1f;
            if (deg == 0)
                yield return 1f;
            else
            if (number == 0)
                yield return 0f;
            else
            {
                for (int i = 0; i < Math.Abs(deg); i++)
                    yield return deg > 0 ? result *= number : result /= number;
            }
        }
    }

    //Task 4

    class ShowPowerRange
    {
        public static float Base(int num, int deg)
        {
            double power = Math.Pow((double)num, (double)1 / deg);
            return (float)power;
        }

        public static IEnumerable<float> PowerRanger(int deg, int start, int finish)
        {
            if (start > finish || start < 0 || finish < 0)
            {
                yield return 0;
                yield break;
            }
            for (int i = start; i <= finish; i++)
                if (Base(i, deg) % 1 == 0)
                    yield return (i);
        }
    }
}
