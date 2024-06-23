namespace IntroducctionToLoops
{
    public class Loops
    {
        static void Main(string[] args)
        {

            WhileLoop();

        }



        //Ejercicio 2 



        public static void ForLoop()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Count Up: " + i);
            }

            Console.WriteLine("-----------------");


            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Count Down: " + i);
                Thread.Sleep(500);

            }


        }



        public static void WhileLoop()
        {
            /*
            int counter = 0;

            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;

            }
            */


            Console.WriteLine("Enter go or stay: ");
            string userChoíce = Console.ReadLine();

            //  bool isGood = true;

            while (userChoíce == "go")
            {
                Console.WriteLine("Go for a mile.");
                Console.WriteLine("wanna keeo going? Enter go");
                userChoíce = Console.ReadLine();

            }


            Console.WriteLine("Finally youre staying.");


        }






    }



}
