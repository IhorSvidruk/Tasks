using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1

    class CalcAsync
    {
        public static async Task PrintSeqAsync(int n)
        {
            await Task.Run(() => Console.WriteLine("Seq[{0}] = {1}", n, Calc.Seq(n)));
        }
    }

    //Task 2

    static class CalcAsync
    {
        public static async Task TaskPrintSeqAsync(int n)
        {
            await Task.Run(() => Console.WriteLine("Seq[{0}] = {1}", n, Calc.Seq(n)));
        }

        public static void PrintStatusIfChanged(this Task task, ref TaskStatus oldStatus)
        {
            var status = task.Status;
            if (status != oldStatus) Console.WriteLine(status);
            oldStatus = status;
        }

        public static void TrackStatus(this Task task)
        {
            var status = task.Status;
            Console.WriteLine(status);
            while (status != TaskStatus.RanToCompletion && status != TaskStatus.Faulted)
            {
                task.PrintStatusIfChanged(ref status);
            }
        }
    }

    //Task 4

    class CalcAsync
    {
        public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int res = await Task.Run(() => Calc.Seq(i));
                yield return (i, res);
            }

        }

        public static async void PrintStream(IAsyncEnumerable<(int, int)> stream)
        {
            await foreach (var item in stream)
            {
                Console.WriteLine("Seq[{0}] = {1}", item.Item1, item.Item2);
            }
        }
    }

    //Task 4

    class CalcAsync
    {
        public static async void PrintSpecificSeqElementsAsync(int[] array)
        {
            Task allTasks = null;
            try
            {
                Task[] tasks = new Task[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    int any = array[i];
                    tasks[i] = Task.Run(() => Console.WriteLine("Seq[{0}] = {1}", any, Calc.Seq(any)));
                }

                allTasks = Task.WhenAll(tasks);
                await allTasks;
            }
            catch (Exception ex)
            {
                foreach (var exep in allTasks.Exception.InnerExceptions)
                {
                    Console.WriteLine("Inner exception: " + exep.Message);
                }
            }
        }
    }

}
