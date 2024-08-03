 namespace ListAPP
{

    public class Product()
    {
        public string Name { get; set; }
        public double Price { get; set; }


    }





    public class Programm
    {

        static void Main(string[] args)

        {
           // MyList();
           FilterWithLinq();
        }


        public static void MyList()
        {


            Product p = new Product();
            List<Product> products = new List<Product> {

                new Product {Name = "Apple", Price = 1.00},
                new Product {Name = "Bananas", Price = 0.30},
                new Product {Name = "Cherris", Price = 0.80},




            };

            products.Add(new Product { Name = "Berries", Price = 2.20 });

            Console.WriteLine("Avalible Products: ");

            foreach (Product product in products)
            {

                Console.WriteLine("Product name: " + product.Name + " for " + product.Price);
            }
            Console.ReadKey();

        }

        public static void FilterWithLinq()
        {


            Product p = new Product();
            List<Product> products = new List<Product> {

                new Product {Name = "Apple", Price = 1.00},
                new Product {Name = "Bananas", Price = 0.30},
                new Product {Name = "Cherris", Price = 0.80},
            };

            //add items to the list
            products.Add(new Product { Name = "Berries", Price = 2.20 });

            //Importan
           List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();
            
            

            Console.WriteLine("Avalible Products for less than $1: ");

            foreach (Product product in cheapProducts)
            {

                Console.WriteLine("Product name: " + product.Name + " for " + product.Price);
            }
            Console.ReadKey();



        }




    }




}