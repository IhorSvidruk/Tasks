using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1
    interface ISwimmable
    {
        void Swim()
        {
            Console.WriteLine("I can swim!");
        }
    }
    interface IFlyable
    {
        int MaxHeight { get { return default; } }
        void Fly()
        {
            Console.WriteLine("I can fly at " + MaxHeight + " meters height!");
        }
    }
    interface IRunnable
    {
        int MaxSpeed { get { return default; } }
        void Run() => Console.WriteLine("I can run up to " + MaxSpeed + " kilometers per hour!");
    }
    interface IAnimal
    {
        int LifeDuration { get { return default; } }
        void Voice()
        {
            Console.WriteLine("No voice!");

        }
        void ShowInfo()
        {
            Console.WriteLine("I am a " + this.ToString() + " and I live approximately " + LifeDuration + " years.");
        }
    }

    class Cat : IAnimal, IRunnable
    {

        public int LifeDuration { get; set; }
        public int MaxSpeed { get; set; }
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Voice()
        {
            Console.WriteLine("Meow!");
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
    class Eagle : IAnimal, IFlyable
    {
        public int LifeDuration { get; set; }
        public void Voice()
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public int MaxHeight { get; set; }
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    class Shark : IAnimal, ISwimmable
    {
        public int LifeDuration { get; set; }
        public void Voice()
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }

    //Task 2

    public interface IAnimal
    {
        public string Name
        {
            get; set;

        }

        public void Voice();
        public void Feed();
    }

    class Cat : IAnimal
    {
        public string Name
        {
            get; set;

        }

        public void Voice()
        {
            Console.WriteLine("Mew");
        }

        public void Feed()
        {
            Console.WriteLine("I eat mice");
        }
    }

    class Dog : IAnimal
    {
        public string Name
        {
            get; set;

        }
        public void Voice()
        {
            Console.WriteLine("Woof");

        }

        public void Feed()
        {
            Console.WriteLine("I eat meat");
        }

    }

    //Task 3

    enum ColourEnum
    {
        Red,
        Green,
        Blue


    }
    interface IColoured
    {
        ColourEnum Colour { get { return ColourEnum.Red; } }
    }
    interface IDocument
    {

        public static string defaultText = "Lorem ipsum";
        public int Pages { get { return 0; } set { } }
        public string Name { get; set; }
        public void AddPages(int _Newpages)
        {
            Pages = Pages + _Newpages;
        }
        void Rename(string A)
        {
            Name = A;
        }



    }
    class ColouredDocument : IColoured, IDocument
    {
        public int Pages { get { return 0; } set { } }
        public string Name { get; set; }
        public ColourEnum Colour { get { return ColourEnum.Red; } set { } }


        public ColouredDocument()
        {

        }

        public ColouredDocument(ColourEnum colour)
        {
            Colour = colour;
        }
    }
    class Example
    {
        public static void Do()
        {
            IDocument doc1 = new ColouredDocument();
            doc1.Name = "Document1";
            Console.WriteLine(doc1.Name);
            doc1.Rename("Document2");
            Console.WriteLine(doc1.Name);


        }
    }


}
