using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1
    internal class Employee
    {
        internal string name;
        private DateTime hiringDate;

        public Employee(string name, DateTime hiringDate)
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }

        public int Experience()
        {
            return (DateTime.Now.DayOfYear >= hiringDate.DayOfYear)
                ? (DateTime.Now.Year - hiringDate.Year)
                : (DateTime.Now.Year - hiringDate.Year) - 1;

        }

        public void ShowInfo()
        {
            Console.WriteLine("{n} has {e} years of experience", this.name, this.Experience());
        }


    }

    class Developer : Employee
    {
        private string programmingLanguage;

        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("{n} is {pl} programmer", this.name, this.programmingLanguage);
        }



    }

    class Tester : Employee

    {
        private bool isAuthomation;

        public Tester(string name, DateTime hiringDate, bool isAuthomation) : base(name, hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{name} is authomated tester and has {ex} year(s) of experience", this.name, this.Experience());
            if (isAuthomation == false)
            {
                Console.WriteLine("{name}  is manual tester and has {ex} year(s) of experience", this.name, this.Experience());
            }
        }



    }

    //Task 2
    abstract class Car
    {
        internal string mark;
        internal int prodYear;

        public void ShowInfo()
        {
            Console.WriteLine("“Mark : {mark},\n Producted in {prodYear}", this.mark, this.prodYear);
        }

    }

    class SportCar : Car
    {
        private int maxSpeed;
        public SportCar(string mark, int prodYear, int maxSpeed)
        {
            this.mark = mark;
            this.prodYear = prodYear;
            this.maxSpeed = maxSpeed;

        }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Maximum speed is {maxSpeed}", this.maxSpeed);
        }

    }

    class Lory : Car
    {
        private double loadCapacity;
        public Lory(string mark, int prodYear, double loadCapacity)
        {
            this.mark = mark;
            this.prodYear = prodYear;
            this.loadCapacity = loadCapacity;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("The load capacity is {loadCapacity}", this.loadCapacity);
        }


    }

    //Task 3

    internal class Science
    {
        public virtual void Awards()
        {
            Console.WriteLine("We can obtain The Nobel Prize");
        }
    }

    class Mathematics : Science
    {
        public override void Awards()
        {
            Console.WriteLine("We don't need any awards,but we still can obtain The Abel Prize that nobody else can!");
        }
    }

    class Physics : Science
    {

    }

    //Task 4
    abstract class ChessFigure
    {
        public abstract void Move();


    }

    class Bishop : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves by a diagonal!");
        }
    }

    class Rook : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves straight!");
        }
    }

    //Task 5
    internal class Acinonychini
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic Acinonychini sound.");
        }
    }

    sealed class Acinonyx : Acinonychini
    {
        public override void MakeSound()
        {
            Console.WriteLine("Acinonyx makes a unique sound.");
        }
    }

    class Puma : Acinonychini
    {
        public override void MakeSound()
        {
            Console.WriteLine("Puma makes a unique sound.");
        }
    }


}
