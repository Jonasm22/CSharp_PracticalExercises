using System.Drawing;

namespace Collection
{
    public class MyCollection
    {
        static void Main(string[] args)
        {

            //AddingAndRemoving();
            //Sorting();
            // Predicates();
            //Squaring();
            MethodAny();

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
            // Define the predicate to check if the number is greater that 10
            
            
            Predicate<int> isGreaterThanTen = x => x > 10;
           //List<int> higherEqualTen =  numbers.FindAll(x => x >= 10);
           // FindAll()
           List<int> higherTen =  numbers.FindAll(isGreaterThanTen);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All number 10 and Higher with 'FindAll methode and predicates'");
            Console.ResetColor();
            foreach (var number in higherTen) 
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

        public static int Squaring(int num1)
        {
            return num1 * num1;
        }



        public static void MethodAny()
        {

            List<int> numbers = [81, 22, 3, 99 ,21 ,5 ,9,10,18];
            Console.WriteLine("Unsorted List.");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            bool hasLangeNumber = numbers.Any(x => x > 20);

            if (hasLangeNumber)
            {
                Console.WriteLine("There are large numbers in the list");
            }
            else
            {
                Console.WriteLine("No large numbers in the list");
            }
         

        }













    }
}