using System.Drawing;

namespace Collection
{
    public class MyCollection
    {
        static void Main(string[] args)
        {

            //AddingAndRemoving();
            //Sorting();
            Predicates();

        }

        public static void AddingAndRemoving()
        {


            //Declaring a list and initializing
            List<String> colors = new List<String>();

            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            colors.Add("red");

            // Alternativ
            //List<String> colors = ["red", "green", "blue", "red"];

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // Remote Methode
            colors.Remove("red");
            Console.WriteLine("Current colors in the list");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }


            bool isDeletingSuccessful = colors.Remove("red");
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("red");

            }
          
            Console.WriteLine("------Current colors  in the colors list!----");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();


        }


        public static void Sorting()
        {

            List<int> numbers = [81, 22, 3 , 99];
            Console.WriteLine("Unsorted List.");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            Console.WriteLine("Sorted");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }


        public static void Predicates()
        {

            List<int> numbers = [81, 22, 3, 99 , 54 ,11 ,1 ,5];
            Console.WriteLine("Unsorted List.");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

           List<int> higherEqualTen =  numbers.FindAll(x => x >= 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All number 10 and Higher ");
            Console.ResetColor();
            foreach (var number in higherEqualTen) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(number);
                Console.ResetColor();
            }


            numbers.Sort();
            Console.WriteLine("Sorted");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }

















    }
}