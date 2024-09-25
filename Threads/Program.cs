using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {

            example_2();

        }

        public static void example_1()
        {
            /*
            Console.WriteLine("Hello, World 1!");
            Thread.Sleep(1000);
            Console.WriteLine("Hello, World 2!");
            Thread.Sleep(1000);
            Console.WriteLine("Hello, World 3!");
            Thread.Sleep(1000);
            Console.WriteLine("Hello, World 4!");

            */
/*
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");

            }).Start();
            
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");

            }).Start();


            new Thread(() =>
             {
                   Thread.Sleep(1000);
                   Console.WriteLine("Thread 3");

             }).Start();

          
            new Thread(() =>
             {
                  Thread.Sleep(1000);
                  Console.WriteLine("Thread 4");

             }).Start();

            */
           

            var taskCompletionSource = new TaskCompletionSource<bool>();
            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread nummer: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(5000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} endet");
            });
            thread.Start();
            var test = taskCompletionSource.Task.Result;
            Console.WriteLine($"Task eas done {test} ");

            Console.ReadLine();
        }


        public static void example_2()
        {
       

            Enumerable.Range(0, 1000).ToList().ForEach(f =>
            {
                new Thread(() =>
                {
                    Console.WriteLine($"Thread nummer: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);

                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} endet");
                }).Start();


            });
        }






    }
}

