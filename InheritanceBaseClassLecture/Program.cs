namespace InheritanceBaseClassLecture.ConstuctorInheritance

{
    internal class Program
    {
        /* static void Main(string[] args)
         {



             Dog myDog = new Dog();
             myDog.MakeSound();


             Cat myCat = new Cat();
             myCat.MakeSound();

             BaseClass myBaseClass = new BaseClass();
             myBaseClass.ShowFields();

             DerivedClass derivedClass = new DerivedClass();
             derivedClass.AccesField();
             derivedClass.ShowFields();

             Console.ReadKey();
             */

        /*Employee joe = new Employee("Joe" , 36);
        joe.DisplayPersonInfo();
        Console.ReadLine();*/

        //Employee joe = new Employee("Joe" , 36 , "Salee Rep" , 1234);
        // joe.DisplayEmployeeInfo();

        static void Main(string[] args)
        {
            Manager carl = new Manager("Carl", 45, "Manager", 5551, 7);
            carl.DisplayManagerInfo();

            carl.BecomeOlder(5);
            carl.DisplayPersonInfo();

            Console.ReadLine();


        }






    }




}









