using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1

    class ParallelUtils<T, TR>
    {
        public Func<T, T, TR> Function { get; set; }
        private T Operand1 { get; set; }
        private T Operand2 { get; set; }
        public TR Result { get; set; }

        public ParallelUtils(Func<T, T, TR> function, T operand1, T operand2)
        {
            Function = function;
            Operand1 = operand1;
            Operand2 = operand2;

        }

        public void StartEvaluation()
        {
            Thread startEvaluation = new Thread(() => Function.Invoke(Operand1, Operand2));
            startEvaluation.Start();
        }

        public void Evaluate()
        {
            Thread evaluation = new Thread(() => Result = Function.Invoke(Operand1, Operand2));
            evaluation.Start();
            evaluation.Join();
        }
    }

    //Task 2

    class MainThreadProgram
    {
        public static (Thread, Thread) Calculator()
        {
            Thread productThread = new Thread(Product);
            productThread.Start();
            Thread sumThread = new Thread(Sum);
            sumThread.Start();
            return (sumThread, productThread);
        }

        public static void Product()
        {
            int product = Enumerable.Range(1, 10).Aggregate((x, y) => x * y);
            Thread.Sleep(10000);
            Console.WriteLine($"Product is: {product}");
        }
        public static void Sum()
        {
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter the {i}{i switch { 1 => "st", 2 => "nd", 3 => "rd", _ => "th" }} number:");
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum is: {sum}");
        }
    }

    //Task 3

    class MyTasks
    {
        public static void Tasks()
        {
            int[] sequence_array = new int[10];

            Task task1 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    sequence_array[i] = i * i;
                }

                Console.WriteLine("Calculated!");
            });

            Task task2 = task1.ContinueWith((Task t) =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Bye!");
            });

            Task task3 = task2.ContinueWith((Task t) =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(sequence_array[i]);
                }
                Console.WriteLine("Bye!");
            });

            task1.Start();
            Task.WaitAll(task1, task2, task3);
            Console.WriteLine("Main done!");
        }
    }

    //Task 4

    class MyProgram
    {
        public static void Counter(int n)
        {
            int facRes = 0, fibRes = 0;
            Thread facThread = new Thread(() => facRes = Factorial(n));
            Thread fibThread = new Thread(() => fibRes = Fibbonachi(n));
            facThread.Start();
            fibThread.Start();
            facThread.Join();


            Console.WriteLine($"Factorial is: {facRes}");
            Console.WriteLine($"Fibbonaci number is: {fibRes}");


        }

        public static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;

            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        public static int Fibbonachi(int y)
        {
            if (y == 0)
            {
                return 0;
            }
            else if (y == 1)
            {
                return 1;
            }
            else
            {
                return Fibbonachi(y - 1) + Fibbonachi(y - 2);
            }
        }
    }

    //Task 5

    class MyThreads
    {
        public static readonly object Den = new object();
        public static readonly object Ada = new object();

        public static int n;
        public static int m;

        public Thread Thread1 = new Thread(
            () =>
            {
                lock (Ada)
                {
                    for (int i = 0; i < 5; i++, n++)
                    {
                        Console.WriteLine("Thread1 n = " + n);
                        ThreadsDemo.ExtraEvaluation(i);
                    }
                }

                Thread.Yield();

                lock (Ada)
                {
                    for (int i = 0; i < 5; i++, m++)
                        Console.WriteLine("Thread1 m = " + m);
                    Console.WriteLine("Thread1 success!");
                }

            }
        );

        public Thread Thread2 = new Thread(
            () =>
            {
                lock (Ada)
                {
                    for (int i = 0; i < 5; i++, m++)
                        Console.WriteLine("Thread2 m = " + m);

                    for (int i = 0; i < 5; i++, n++)
                        Console.WriteLine("Thread2 n = " + n);
                    Console.WriteLine("Thread2 success!");

                }
            }
        );
    }

}
