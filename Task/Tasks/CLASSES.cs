using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //TASK 1
    class MyAccessModifiers
    {
        private int birthYear;
        protected string personalInfo;
        private protected string IdNumber;
        static byte averageMiddleAge = 50;
        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.personalInfo = personalInfo;
            this.IdNumber = IdNumber;
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }
        }

        internal string Name
        {
            get; set;

        }

        public string NickName
        {
            get; internal set;
        }

        protected internal bool HasLivedHalfOfLife()
        {
            return Age >= averageMiddleAge;
        }

        public static bool operator ==(MyAccessModifiers first, MyAccessModifiers second)
        {
            return first.Name == second.Name && first.Age == second.Age && first.personalInfo == second.personalInfo;
        }

        public static bool operator !=(MyAccessModifiers first, MyAccessModifiers second)
        {
            return !(first == second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    //TASK 2
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int[] GetXYPair()
        {
            return new int[] { x, y };
        }
        protected internal double Distance(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));

            return distance;
        }
        protected internal double Distance(Point point)
        {
            double distance = Math.Sqrt(Math.Pow((point.x - this.x), 2) + Math.Pow((point.y - this.y), 2));
            return distance;
        }
        public static explicit operator double(Point point)
        {

            return point.Distance(0, 0);
        }

    }

    //TASK 3
    class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            int gcdNumber = gcd(numerator, denominator);
            int simplifiedNumerator = numerator / gcdNumber;
            int simplifiedDenominator = denominator / gcdNumber;

            if (simplifiedDenominator < 0)
            {
                simplifiedNumerator = -simplifiedNumerator;
                simplifiedDenominator = -simplifiedDenominator;
            }

            this.numerator = simplifiedNumerator;
            this.denominator = simplifiedDenominator;
        }

        private static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }

        public static Fraction operator +(Fraction a) => a;

        public static Fraction operator -(Fraction a) => new Fraction(-a.numerator, a.denominator);

        public static Fraction operator !(Fraction a) => new Fraction(a.denominator, a.numerator);

        public static Fraction operator +(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);

        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.denominator == 0)
                throw new DivideByZeroException();

            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        public static bool operator ==(Fraction a, Fraction b) => a.ToString() == b.ToString();

        public static bool operator !=(Fraction a, Fraction b) => !(a == b);

        public override bool Equals(object obj) => this == (Fraction)obj;

        public override int GetHashCode() => ToString().GetHashCode();

        public override string ToString() => $"{numerator} / {denominator}";
    }

    //TASK 4
    public abstract class CloseableResource
    {
        public void Close()
        {

        }
    }

    public class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                }
                else
                {
                    Console.WriteLine("Disposing by GC");
                }
                Close();
                disposed = true;
            }
        }

        ~DisposePatternImplementer()
        {
            Dispose(false);
        }
    }

    //TASK 5
    public class Person
    {
        protected int yearOfBirth;
        protected string healthInfo;
        protected string name;
        public string Name { get; }

        public Person(int yearOfBirth, string healthInfo, string name)
        {
            this.yearOfBirth = yearOfBirth;
            this.healthInfo = healthInfo;
            this.name = name;
        }
        public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
    }

    public class Child : Person
    {
        private string childIDNumber;

        public Child(int yearOfBirth, string name, string healthInfo, string childIdNumber) : base(yearOfBirth, healthInfo, name)
        {
            this.childIDNumber = childIdNumber;

        }
        public override string ToString()
        {
            return $"{name} {childIDNumber}";
        }
    }
    public class Adult : Person
    {

        private string passportNumber;

        public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber) : base(yearOfBirth, healthInfo, name)
        {

            this.passportNumber = passportNumber;

        }
        public override string ToString()
        {
            return $"{name} {passportNumber}";
        }
    }
}
