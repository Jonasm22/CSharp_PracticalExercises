namespace Dictionaries
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // IntroductionDictionaries();
            DictionariesOOP();
        }




        class Employee
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int Salary { get; set; }

            public Employee(string name, int age, int salary)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }

         
        }



        public static void DictionariesOOP()
        {

            // Key - value
            // Declaring and initializing a Dictionary

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John", 22, 2000));
            employees.Add(2, new Employee("Lisa", 30, 1100));
            employees.Add(3, new Employee("maria", 41, 3200));
            employees.Add(4, new Employee("evelin", 54, 4000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name} " +
                    $" earns {item.Value.Salary} " + 
                    $" and is {item.Value.Age} years old!"
                    );
            }

            Console.ReadKey();

        }








        public static void IntroductionDictionaries()
        {
            // Key - value
            // Declaring and initializing a Dictionary

            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "John");
            employees.Add(102, "Bob");
            employees.Add(103, "Lisa");
            employees.Add(104, "Jenny");
            employees.Add(105, "Maria");

            // Accessing items from a dictonaries
            string name = employees[101];
            // Console.WriteLine(name);

            // Update data in a Dictionary
            employees[102] = "James";

            // removing
            employees.Remove(101);

            employees[104] = "Mike";

            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "moke");

            }
            bool added = employees.TryAdd(102, "Michael");

            if (!added)
            {
                Console.WriteLine("Employee already exist");
            }

            /*
            int counter = 101;

            while(employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Jesus");
            */


            //Interating with the Dictionary Data
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, NAME: {employee.Value}");
            }



            Console.ReadKey();


        }








    }
}
