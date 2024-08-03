namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Example2();


        }

        public static void Example1()
        {

            int? age = null; // int? is a nullable 

            int myAge = 35;


            //Console.Write("Imprime -> : " + age);

            if (age.HasValue)
            {
                Console.Write("Imprime -> : " + age.Value);
            }
            else
            {

                Console.Write("Age is not specified");
            }

            Console.ReadKey();

        }


        public static void Example2()
        {
            Console.WriteLine("Ingrese su edad:");
            string entradaEdad = Console.ReadLine();

            // Convertimos la entrada a un entero nulo para manejar posibles errores de conversión
            int? edad = int.TryParse(entradaEdad, out int edadInt) ? edadInt : (int?)null;

            if (edad.HasValue)
            {
                Console.WriteLine($"Su edad es: {edad}");
            }
            else
            {
                Console.WriteLine("Edad inválida. Ingrese un número entero.");
            }



        }



    }
}
