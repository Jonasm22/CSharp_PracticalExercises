namespace Conditionals
{
     class Program
    {
        static void Main(string[] args)
        {


            AreEquals();


       
        }

        public static void AreEquals()
        {

            int nummer1 = 2;
            int nummer2 = 3;

            Console.Write("Add a nummer to see if your nummer is the same with mine: ");
            int prueba = int.Parse(Console.ReadLine());

            if(prueba == nummer1)
            {

                Console.WriteLine("Are the same.");

            }
            else
            {
                Console.WriteLine("Are not the same.");

            }
          
          

            




        }
    





        public static void CondicionalesTwo()
        {
            int age = 16;
            bool isWithParents = true;


            if(age >= 13 && isWithParents)
            {
                Console.WriteLine("Go to in the club whit your parents");
            }

            else if (age > 18)
            {
                Console.WriteLine("GO party in the club");

            }
            else
            {
                Console.WriteLine("GO party in Kinder Garden");
            }
        }











        public static void LogicCoditional()
        {

            int num1 = 5;
            int num2 = 6;

            bool isHigher = num1 > num2;



            bool isRainy = true;
            bool hasUmbrella = false;

            //Logical Operators
            //AND &&
            //OR ||
            //NOT !



            // Variants of the OR operator

            //TRUE || TRUE -> True
            //TRUE ||  TRUE -> true
            //FALSE || TRUE -> true
            //FALSE ||FALSE -> false

            // Variants of the AND operator

            //TRUE || TRUE -> True
            //TRUE ||  FALSE -> FALSE
            //FALSE || TRUE -> FALSE
            //FALSE ||FALSE -> false


            /* if (isRainy &&  !hasUmbrella)
             {
                 Console.WriteLine("IM  getting wet");
             }*/

            bool isLoggedIn;

            isLoggedIn = true;

            // Assign a value to isLoggedIn based on user input or condition
            


            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }








        }

        
    }
}
